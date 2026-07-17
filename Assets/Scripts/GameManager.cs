using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set;}

    [SerializeField] private List<MoneyGenerator> moneyGeneratorsList;

    [SerializeField] private int moneyBalance;
    [SerializeField] private float updateTime = 1f;
    private float updateTimeCounter;
    private int lastGeneratedIncome;
    
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        CollectMoney();
    }

    private void CollectMoney()
    {
        updateTimeCounter += Time.deltaTime;

        if (updateTimeCounter > updateTime)
        {
            int income = 0;
            
            foreach (MoneyGenerator moneyGenerator in moneyGeneratorsList)
            {
                income += moneyGenerator.CalculateIncomePerSecond();
            }

            moneyBalance += income;
            lastGeneratedIncome = income;
            
            updateTimeCounter = 0;
            
            Debug.Log(lastGeneratedIncome);
        }
    }

    public void PayForUpgrade(int upgradePrice)
    {
        moneyBalance -= upgradePrice;
    }

    public int GetMoneyBalance() => moneyBalance;

    public int GetLastGeneratedIncome() => lastGeneratedIncome;
}
