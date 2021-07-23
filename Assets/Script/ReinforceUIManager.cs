using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    [SerializeField]
    GraphicCard[] GraphicCards;

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
    }

    public void LevelUpCheck2()
    {
        if (GraphicCards[1].level * 500 >= gameManager.money) return;
        gameManager.money -= GraphicCards[1].level * 500;
        GraphicCards[1].levelUp();
    }
    public void LevelUpCheck3()
    {
        if (GraphicCards[2].level * 1000 >= gameManager.money) return;
        gameManager.money -= GraphicCards[2].level * 1000;
        GraphicCards[2].levelUp();
    }
    public void LevelUpCheck4()
    {
        if (GraphicCards[3].level * 2500 >= gameManager.money) return;
        gameManager.money -= GraphicCards[3].level * 2500;
        GraphicCards[3].levelUp();
    }
    public void LevelUpCheck5()
    {
        if (GraphicCards[4].level * 5000 >= gameManager.money) return;
        gameManager.money -= GraphicCards[4].level * 5000;
        GraphicCards[4].levelUp();
    }
}