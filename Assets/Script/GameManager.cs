using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public int money = 0;

    [SerializeField]
    Button[] buttons;

    [SerializeField]
    GameObject menus;

    [SerializeField]
    GameObject GraphicCards;

    [SerializeField]
    GameObject CoinObject;

    Vector2 menuPos;

    public bool battleing = false;

    UIManager uIManager;

    void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
        uIManager.UpdateUI();
        menuPos = menus.transform.position;
        CoinObject.GetComponent<SpriteRenderer>().material.DOFade(0, 0.0f);

        for (int i = 0; i < 10; i++)
        {
            buttons[i].onClick.AddListener(() =>
            {
                StartBattle(i);
            });
        }
    }

    public void StartBattle(int type)
    {
        if (battleing) return;
        Sequence DOSequence = DOTween.Sequence();
        CoinObject.SetActive(true);
        Debug.Log(menuPos);
        DOSequence.Append(menus.transform.DOMove(menus.transform.TransformPoint(new Vector2(0, -5)), 1f));
        DOSequence.Append(GraphicCards.transform.DOMove(new Vector2(0, -3.5f), 1f));
        DOSequence.Append(CoinObject.GetComponent<SpriteRenderer>().material.DOFade(1, 0.5f));

        switch (type)
        {
            case 0:
                CoinObject.GetComponent<CoinScript>().hp = 1;
                CoinObject.GetComponent<CoinScript>().level = 1;
                break;
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;
            case 9:

                break;
        }

        DOSequence.AppendCallback(() =>
        {
            battleing = true;
        });
    }

    public void ExitButton()
    {
        if (!battleing) return;
        Sequence DOSequence = DOTween.Sequence();
        DOSequence.Append(CoinObject.GetComponent<SpriteRenderer>().material.DOFade(0, 0.5f));
        DOSequence.Append(GraphicCards.transform.DOMove(new Vector2(0, 0f), 1f));
        DOSequence.Append(menus.transform.DOMove(menuPos, 1f));
        battleing = false;
    }
}
