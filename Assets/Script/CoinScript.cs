using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinScript : MonoBehaviour
{
    public int type = 0;
    public int level = 0;
    public int hp = 0;
    public int money = 0;

    GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    
    public void damaged(int damage)
    {
        if((hp - damage) <= 0)
        {
            Death();
            return;
        }
        hp -= damage;
    }

    void Death()
    {

        Sequence DOSequence = DOTween.Sequence();
        DOSequence.Append(gameObject.GetComponent<SpriteRenderer>().material.DOFade(0, 1));
        DOSequence.AppendInterval(1f);
        DOSequence.AppendCallback(() =>
        {
            gameManager.money += money;
            gameManager.ExitButton();
        });
    }
}
