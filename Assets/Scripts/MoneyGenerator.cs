using UnityEngine;

public class MoneyGenerator : MonoBehaviour
{
    [SerializeField] private int startPrice = 10;
    [SerializeField] private float upgradePriceMultiplier;
    [SerializeField] private float moneyPerUpgrade;

    private int level;


    private int CalculateIncome()
    {
        int income = Mathf.RoundToInt(startPrice * Mathf.Pow(upgradePriceMultiplier,level));
        return income;
    }
}
