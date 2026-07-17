using System;
using TMPro;
using UnityEngine;

public class UI_RessourcesScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text moneyBalanceText;
    [SerializeField] private TMP_Text incomePerSecond;
    
    [SerializeField] private float updateTime = 0.2f;
    private float updateTimeCounter;

    private void Start()
    {
        updateTimeCounter = 0f;
    }

    private void Update()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        updateTimeCounter += Time.deltaTime;

        if (updateTimeCounter > updateTime)
        {
            moneyBalanceText.text = GameManager.instance.GetMoneyBalance().ToString();

            //incomePerSecond.text = GameManager.instance.GetLastGeneratedIncome().ToString();
                
            updateTimeCounter = 0f;
        }
    }
}
