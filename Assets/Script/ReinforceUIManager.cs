using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    [SerializeField]
    GraphicCard[] GraphicCards;

    [SerializeField]
    double[] reinforcecost = new double[] { 1, 50, 100, 100, 250, 300, 400, 500, 600, 800, 1000};

    GameManager gameManager = null;
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }


    public void LevelUpCheck1()
    {
        if (GraphicCards[0].level * 100 >= gameManager.money) return;
        gameManager.money -= GraphicCards[0].level * 100;
        GraphicCards[0].levelUp();
        reinforcecost[0] *= 100;
    }

    public void LevelUpCheck2()
    {
        if (GraphicCards[1].level * 500 >= gameManager.money) return;
        gameManager.money -= GraphicCards[1].level * 500;
        GraphicCards[1].levelUp();
        reinforcecost[1] *= 500;
    }
    public void LevelUpCheck3()
    {
        if (GraphicCards[2].level * 1000 >= gameManager.money) return;
        gameManager.money -= GraphicCards[2].level * 1000;
        GraphicCards[2].levelUp();
        reinforcecost[2] *= 1000;
    }
    public void LevelUpCheck4()
    {
        if (GraphicCards[3].level * 2500 >= gameManager.money) return;
        gameManager.money -= GraphicCards[3].level * 2500;
        GraphicCards[3].levelUp();
        reinforcecost[3] *= 2500;
    }
    public void LevelUpCheck5()
    {
        if (GraphicCards[4].level * 5000 >= gameManager.money) return;
        gameManager.money -= GraphicCards[4].level * 5000;
        GraphicCards[4].levelUp();
        reinforcecost[4] *= 5000;
    }
}