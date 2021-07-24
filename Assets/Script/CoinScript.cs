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

    MoneyManager moneyManager;
    GameManager gameManager;
    InvManager invManager;
    UIManager uiManager;

    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
        gameManager = FindObjectOfType<GameManager>();
        invManager = FindObjectOfType<InvManager>();
        uiManager = FindObjectOfType<UIManager>();
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
        gameManager.ExitButton();
        Sequence DOSequence = DOTween.Sequence();
        DOSequence.Append(gameObject.GetComponent<SpriteRenderer>().material.DOFade(0, 1));
        DOSequence.AppendInterval(1f);
        DOSequence.AppendCallback(() =>
        {
            moneyManager.money += money;
            int random = Random.Range(0, 100);
            Debug.Log(random);
            if (random >= 50)
                invManager.AddItem(type);
            uiManager.UpdateUI();
        });
    }
}
