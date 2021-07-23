using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public int debt = 250000;
    public int money = 0;

    private void Start()
    {
        LoadMoneyData();
    }

    public void DebtCheck()
    {
        if (money <= 250000) return;
        money -= debt;

    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.Save();
    }

    public void LoadMoneyData()
    {
        if (PlayerPrefs.HasKey("Money"))
            return;
        money = PlayerPrefs.GetInt("Money");
        money = 10000;
    }
}
