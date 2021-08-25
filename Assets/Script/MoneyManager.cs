using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public int debt = 250000;
    public int money = 0;
    UIManager uIManager;

    private void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
        LoadMoneyData();
    }

    public void DebtCheck()
    {
        if (money <= 250000) return;
        money -= debt;
        SaveMoneyData();
    }

    public void SaveMoneyData()
    {
        PlayerPrefs.SetInt("Money", money);
    }

    public void LoadMoneyData()
    {
        PlayerPrefs.GetInt("Money", 0);
        uIManager.UpdateUI();
    }
}
