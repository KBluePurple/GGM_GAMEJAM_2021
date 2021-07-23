using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    Text MoneyText;

    [SerializeField]
    Text MoneyText2;

    [SerializeField]
    Text[] UpgradeValues;

    MoneyManager moneyManager;

    ReinforceUIManager reinforceUIManager;

    UIManager uIManager;

    void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
        moneyManager = FindObjectOfType<MoneyManager>();
        reinforceUIManager = FindObjectOfType<ReinforceUIManager>();
    }

    public void UpdateUI()
    {
        MoneyText.text = string.Format("현재 돈 : {0}₩", moneyManager.money);
        MoneyText2.text = string.Format("남은 채무 : {0}₩", moneyManager.debt);

        UpgradeValues[0].text = string.Format("{0}₩", reinforceUIManager.GraphicCards[0].level * 100);
        UpgradeValues[1].text = string.Format("{0}₩", reinforceUIManager.GraphicCards[1].level * 500);
        UpgradeValues[2].text = string.Format("{0}₩", reinforceUIManager.GraphicCards[2].level * 1000);
        UpgradeValues[3].text = string.Format("{0}₩", reinforceUIManager.GraphicCards[3].level * 2500);
        UpgradeValues[4].text = string.Format("{0}₩", reinforceUIManager.GraphicCards[4].level * 5000);
    }

    public void CloseReinforcePopup()
    {

    }
}
