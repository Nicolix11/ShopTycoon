using System;
using UnityEngine;

public class MoneyGenerator_Visuals : MonoBehaviour
{
    [SerializeField] private MoneyGenerator moneyGenerator;
    
    [Header("Object Levels")]
    [SerializeField] private GameObject upgrade1;
    [SerializeField] private GameObject upgrade2;
    [SerializeField] private GameObject upgrade3;


    private void Awake()
    {
        moneyGenerator.buyedUpgrade += MoneyGenerator_BuyedUpgrade;
    }

    private void MoneyGenerator_BuyedUpgrade(object sender, EventArgs e)
    {
        //UpdateMoneyGeneratorVisual();
    }

    private void UpdateMoneyGeneratorVisual()
    {
        if (moneyGenerator.GetCurrentLevel() == 0)
        {
            upgrade1.SetActive(false);
            upgrade2.SetActive(false);
            upgrade3.SetActive(false);
        }
        else if (moneyGenerator.GetCurrentLevel() > 0 && moneyGenerator.GetCurrentLevel() < 50)
        {
            upgrade1.SetActive(true);
            upgrade2.SetActive(false);
            upgrade3.SetActive(false);
        }
        else if (moneyGenerator.GetCurrentLevel() >= 50 && moneyGenerator.GetCurrentLevel() < 100)
        {
            upgrade1.SetActive(false);
            upgrade2.SetActive(true);
            upgrade3.SetActive(false);
        }
        else if (moneyGenerator.GetCurrentLevel() == 100)
        {
            upgrade1.SetActive(false);
            upgrade2.SetActive(false);
            upgrade3.SetActive(true);
        }
    }
}
