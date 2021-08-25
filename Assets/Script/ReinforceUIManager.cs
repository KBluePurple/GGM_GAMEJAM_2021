using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinforceUIManager : MonoBehaviour
{
    public GraphicCard[] GraphicCards;
    public double[] reinforcecost = new double[] { 10, 50, 100, 100, 250, 300, 400, 500, 600, 800, 1000};
    UIManager uIManager;
    MoneyManager moneyManager = null;
    PopManager popManager = null;
    AudioManager audioManager = null;
    InvManager invManager = null;
    void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
        moneyManager = FindObjectOfType<MoneyManager>();
        popManager = FindObjectOfType<PopManager>();
        audioManager = FindObjectOfType<AudioManager>();
        invManager = FindObjectOfType<InvManager>();
    }

    void FaildUpgrade()
    {
        popManager.ReinforceError();
        audioManager.PlaySound("FALSE");
    }

    public void LevelUpCheck1(bool free = false)
    {
        if(!free)
        {
            if (GraphicCards[0].level * 100 >= moneyManager.money || GraphicCards[0].level >= 25)
            {
                FaildUpgrade();
                return;
            }
            moneyManager.money -= GraphicCards[0].level * 100;
            audioManager.PlaySound("CHOOSE");
            moneyManager.SaveMoneyData();
            invManager.SaveItems();
        }
        GraphicCards[0].levelUp();
        invManager.inventory.rainforceLevel[0]++;
        reinforcecost[0] *= 100;
        uIManager.UpdateUI();
    }

    public void LevelUpCheck2(bool free)
    {
        if(!free)
        {
            if (GraphicCards[1].level * 500 > moneyManager.money || GraphicCards[1].level >= 25)
            {
                FaildUpgrade();
                return;
            }
            moneyManager.money -= GraphicCards[1].level * 500;
            audioManager.PlaySound("CHOOSE");
            moneyManager.SaveMoneyData();
            invManager.SaveItems();
        }
        GraphicCards[1].levelUp();
        invManager.inventory.rainforceLevel[1]++;
        reinforcecost[1] *= 500;
        uIManager.UpdateUI();
    }
    public void LevelUpCheck3(bool free)
    {
        if(!free)
        {
            if (GraphicCards[2].level * 1000 > moneyManager.money || GraphicCards[2].level >= 25)
            {
                FaildUpgrade();
                return;
            }
            moneyManager.money -= GraphicCards[2].level * 1000;
            audioManager.PlaySound("CHOOSE");
            moneyManager.SaveMoneyData();
            invManager.SaveItems();
        }
        GraphicCards[2].levelUp();
        invManager.inventory.rainforceLevel[2]++;
        reinforcecost[2] *= 1000;
        uIManager.UpdateUI();
    }
    public void LevelUpCheck4(bool free)
    {
        if(!free)
        {
            if (GraphicCards[3].level * 2500 > moneyManager.money || GraphicCards[3].level >= 25)
            {
                FaildUpgrade();
                return;
            }
            moneyManager.money -= GraphicCards[3].level * 2500;
            audioManager.PlaySound("CHOOSE");
            moneyManager.SaveMoneyData();
            invManager.SaveItems();
        }
        GraphicCards[3].levelUp();
        invManager.inventory.rainforceLevel[3]++;
        reinforcecost[3] *= 2500;
        uIManager.UpdateUI();
    }
    public void LevelUpCheck5(bool free)
    {
        if(!free)
        {
            if (GraphicCards[4].level * 5000 > moneyManager.money || GraphicCards[4].level >= 25)
            {
                FaildUpgrade();
                return;
            }
            moneyManager.money -= GraphicCards[4].level * 5000;
            audioManager.PlaySound("CHOOSE");
            moneyManager.SaveMoneyData();
            invManager.SaveItems();
        }
        GraphicCards[4].levelUp();
        invManager.inventory.rainforceLevel[4]++;
        reinforcecost[4] *= 5000;
        uIManager.UpdateUI();
    }
}