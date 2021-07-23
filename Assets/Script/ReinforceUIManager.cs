using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinforceUIManager : MonoBehaviour
{
    public GraphicCard[] GraphicCards;

    [SerializeField]
    double[] reinforcecost = new double[] { 10, 50, 100, 100, 250, 300, 400, 500, 600, 800, 1000};
    UIManager uIManager;

    MoneyManager moneyManager = null;

    PopManager popManager = null;
    void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
        moneyManager = FindObjectOfType<MoneyManager>();
        popManager = FindObjectOfType<PopManager>();
    }

    void FaildUpgrade()
    {
        popManager.ReinforceError();
    }

    public void LevelUpCheck1()
    {
        if (GraphicCards[0].level * 100 >= moneyManager.money || GraphicCards[0].level >= 25)
        {
            FaildUpgrade();
            return;
        }
        moneyManager.money -= GraphicCards[0].level * 100;
        GraphicCards[0].levelUp();
        reinforcecost[0] *= 100;
        uIManager.UpdateUI();
    }

    public void LevelUpCheck2()
    {
        if (GraphicCards[1].level * 500 >= moneyManager.money || GraphicCards[1].level >= 25)
        {
            FaildUpgrade();
            return;
        }
        moneyManager.money -= GraphicCards[1].level * 500;
        GraphicCards[1].levelUp();
        reinforcecost[1] *= 500;
        uIManager.UpdateUI();
    }
    public void LevelUpCheck3()
    {
        if (GraphicCards[2].level * 1000 >= moneyManager.money || GraphicCards[2].level >= 25)
        {
            FaildUpgrade();
            return;
        }
        moneyManager.money -= GraphicCards[2].level * 1000;
        GraphicCards[2].levelUp();
        reinforcecost[2] *= 1000;
        uIManager.UpdateUI();
    }
    public void LevelUpCheck4()
    {
        if (GraphicCards[3].level * 2500 >= moneyManager.money || GraphicCards[3].level >= 25)
        {
            FaildUpgrade();
            return;
        }
        moneyManager.money -= GraphicCards[3].level * 2500;
        GraphicCards[3].levelUp();
        reinforcecost[3] *= 2500;
        uIManager.UpdateUI();
    }
    public void LevelUpCheck5()
    {
        if (GraphicCards[4].level * 5000 >= moneyManager.money || GraphicCards[4].level >= 25)
        {
            FaildUpgrade();
            return;
        }
        moneyManager.money -= GraphicCards[4].level * 5000;
        GraphicCards[4].levelUp();
        reinforcecost[4] *= 5000;
        uIManager.UpdateUI();
    }
}