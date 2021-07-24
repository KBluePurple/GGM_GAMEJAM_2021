using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public int debt = 250000;
    public int money = 0;


    private void Awake()
    {
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
        PlayerPrefs.Save();
    }

    public void LoadMoneyData()
    {
        if (PlayerPrefs.HasKey("Money"))
            return;
        money = PlayerPrefs.GetInt("Money", 0);
    }
}
