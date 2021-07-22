using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    GraphicCardManager graphicCardManager = null;
    MoneyManager moneyManager = null;
    void Start()
    {
        graphicCardManager = FindObjectOfType<GraphicCardManager>();
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    public void LevelUpCheck1()
    {
        if (graphicCardManager.graphicCard1Level * 100 >= moneyManager.money) return;
        moneyManager.money -= graphicCardManager.graphicCard1Level * 100;
        graphicCardManager.LevelUp1();
    }

    public void LevelUpCheck2()
    {
        if (graphicCardManager.graphicCard2Level * 500 >= moneyManager.money) return;
        moneyManager.money -= graphicCardManager.graphicCard2Level * 500;
        graphicCardManager.LevelUp2();
    }
    public void LevelUpCheck3()
    {
        if (graphicCardManager.graphicCard3Level * 1000 >= moneyManager.money) return;
        moneyManager.money -= graphicCardManager.graphicCard3Level * 1000;
        graphicCardManager.LevelUp3();
    }
    public void LevelUpCheck4()
    {
        if (graphicCardManager.graphicCard4Level * 2500 >= moneyManager.money) return;
        moneyManager.money -= graphicCardManager.graphicCard4Level * 2500;
        graphicCardManager.LevelUp4();
    }
    public void LevelUpCheck5()
    {
        if (graphicCardManager.graphicCard5Level * 5000 >= moneyManager.money) return;
        moneyManager.money -= graphicCardManager.graphicCard5Level * 5000;
        graphicCardManager.LevelUp5();
    }
}