using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinScript : MonoBehaviour
{
    public int type = 0;
    public int level = 0;
    public int maxhp = 0;
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
        // 0 1000
        // 0 50
        float n = 1000f / (float)maxhp;
        Debug.Log(n);
        gameManager.HealthBar.transform.GetChild(0).GetComponent<RectTransform>().sizeDelta = new Vector2((float)hp * n, 100f);
    }

    void Death()
    {
        gameManager.HealthBar.GetComponent<RectTransform>().sizeDelta = new Vector2(1000, 100);
        gameManager.ExitButton();
        Sequence DOSequence = DOTween.Sequence();
        DOSequence.Append(gameObject.GetComponent<SpriteRenderer>().material.DOFade(0, 1));
        DOSequence.AppendInterval(1f);
        DOSequence.AppendCallback(() =>
        {
            moneyManager.money += money;
            int random = Random.Range(0, 100);
            Debug.Log(random);
            if (random >= 20)
                invManager.AddItem(type);
            moneyManager.SaveMoneyData();
            gameManager.HealthBar.GetComponent<RectTransform>().sizeDelta = new Vector2(1000, 100);
            uiManager.UpdateUI();
        });
    }
}
