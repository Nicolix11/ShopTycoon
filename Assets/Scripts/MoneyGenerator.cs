using System;
using UnityEngine;

public class MoneyGenerator : MonoBehaviour
{
    public event EventHandler buyedUpgrade;
    
    [SerializeField] private int startPrice = 10;
    [SerializeField] private float upgradePriceMultiplier;
    [SerializeField] private float moneyPerUpgrade = 2;

    [SerializeField] private int level = 0;


    private void Start()
    {
        buyedUpgrade?.Invoke(this, EventArgs.Empty);
    }

    private int CalculateUpgradePrice()
    {
        int income = Mathf.RoundToInt(startPrice * Mathf.Pow(upgradePriceMultiplier,level));
        
        return income;
    }

    public int CalculateIncomePerSecond()
    {
        return Mathf.RoundToInt(moneyPerUpgrade * level);
    }

    public bool CanBuyUpgrade()
    {
        if (GameManager.instance.GetMoneyBalance() > CalculateUpgradePrice())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void UpgradeMoneyGenerator()
    {
        level++;
        
        GameManager.instance.PayForUpgrade(CalculateUpgradePrice());
        
        buyedUpgrade?.Invoke(this, EventArgs.Empty);
    }

    public int GetCurrentLevel() => level;
}
