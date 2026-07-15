using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set;}

    private List<MoneyGenerator> moneyGeneratorsList;

    private int moneyBalance;
    
    
    private void Awake()
    {
        instance = this;
    }

    private void PayForUpgrade(int upgradePrice)
    {
        moneyBalance -= upgradePrice;
    }

    public int GetMoneyBalance() => moneyBalance;
}
