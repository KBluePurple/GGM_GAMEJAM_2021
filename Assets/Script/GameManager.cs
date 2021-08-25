using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public int money = 0;

    [SerializeField]
    GameObject menus;

    [SerializeField]
    GameObject GraphicCards;

    [SerializeField]
    GameObject CoinObject;

    public GameObject HealthBar;

    [SerializeField]
    Sprite[] CoinImages;

    [SerializeField]
    GameObject MainScene;

    [SerializeField]
    GameObject Webtoon;

    Vector2 menuPos;

    public bool battleing = false;

    UIManager uIManager;

    public int level = 1;

    void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
        uIManager.UpdateUI();
        menuPos = menus.transform.position;
        CoinObject.GetComponent<SpriteRenderer>().material.DOFade(0, 0.0f);
    }

    public void StartBattle1()
    {
        StartBattle(0);
    }
    public void StartBattle2()
    {
        StartBattle(1);
    }
    public void StartBattle3()
    {
        StartBattle(2);
    }
    public void StartBattle4()
    {
        StartBattle(3);
    }
    public void StartBattle5()
    {
        StartBattle(4);
    }
    public void StartBattle6()
    {
        StartBattle(5);
    }
    public void StartBattle7()
    {
        StartBattle(6);
    }
    public void StartBattle8()
    {
        StartBattle(7);
    }
    public void StartBattle9()
    {
        StartBattle(8);
    }
    public void StartBattle10()
    {
        StartBattle(9);
    }


    public void addLevel()
    {
        if (level >= 10) return;
        level++;
        uIManager.UpdateUI();
    }

    public void minusLevel()
    {
        if (level <= 1) return;
        level--;
        uIManager.UpdateUI();
    }

    public void StartBattle(int type)
    {

        Debug.Log(type);
        Debug.Log(level);
        if (battleing) return;
        HealthBar.GetComponent<RectTransform>().sizeDelta = new Vector2(1000, 100);
        Sequence DOSequence = DOTween.Sequence();
        CoinObject.SetActive(true);
        Debug.Log(menuPos);
        DOSequence.Append(menus.transform.DOMove(menus.transform.TransformPoint(new Vector2(0, -5)), 1f));
        DOSequence.Append(GraphicCards.transform.DOMove(new Vector2(0, -3.5f), 1f));
        DOSequence.Append(CoinObject.GetComponent<SpriteRenderer>().material.DOFade(1, 0.5f));

        switch (type)
        {
            case 0:
                CoinObject.GetComponent<CoinScript>().type = 0;
                CoinObject.GetComponent<CoinScript>().maxhp = level * 10;
                CoinObject.GetComponent<CoinScript>().hp = level * 10;
                CoinObject.GetComponent<CoinScript>().level = level;
                CoinObject.GetComponent<CoinScript>().money = 50 + level * 25;
                CoinObject.GetComponent<SpriteRenderer>().sprite = CoinImages[0];
                break;
            case 1:
                CoinObject.GetComponent<CoinScript>().type = 1;
                CoinObject.GetComponent<CoinScript>().maxhp = level * 50;
                CoinObject.GetComponent<CoinScript>().hp = level * 50;
                CoinObject.GetComponent<CoinScript>().level = level;
                CoinObject.GetComponent<CoinScript>().money = 250 + level * 125;
                CoinObject.GetComponent<SpriteRenderer>().sprite = CoinImages[1];
                break;
            case 2:
                CoinObject.GetComponent<CoinScript>().type = 2;
                CoinObject.GetComponent<CoinScript>().maxhp = level * 100;
                CoinObject.GetComponent<CoinScript>().hp = level * 100;
                CoinObject.GetComponent<CoinScript>().level = level;
                CoinObject.GetComponent<CoinScript>().money = 500 + level * 250;
                CoinObject.GetComponent<SpriteRenderer>().sprite = CoinImages[2];
                break;
            case 3:
                CoinObject.GetComponent<CoinScript>().type = 3;
                CoinObject.GetComponent<CoinScript>().maxhp = level * 250;
                CoinObject.GetComponent<CoinScript>().hp = level * 250;
                CoinObject.GetComponent<CoinScript>().level = level;
                CoinObject.GetComponent<CoinScript>().money = 1250 + level * 625;
                CoinObject.GetComponent<SpriteRenderer>().sprite = CoinImages[3];
                break;
            case 4:
                CoinObject.GetComponent<CoinScript>().type = 4;
                CoinObject.GetComponent<CoinScript>().maxhp = level * 300;
                CoinObject.GetComponent<CoinScript>().hp = level * 300;
                CoinObject.GetComponent<CoinScript>().level = level;
                CoinObject.GetComponent<CoinScript>().money = 1500 + level * 750;
                CoinObject.GetComponent<SpriteRenderer>().sprite = CoinImages[4];
                break;
            case 5:
                CoinObject.GetComponent<CoinScript>().type = 5;
                CoinObject.GetComponent<CoinScript>().maxhp = level * 400;
                CoinObject.GetComponent<CoinScript>().hp = level * 400;
                CoinObject.GetComponent<CoinScript>().level = level;
                CoinObject.GetComponent<CoinScript>().money = 2000 + level * 1000;
                CoinObject.GetComponent<SpriteRenderer>().sprite = CoinImages[5];
                break;
            case 6:
                CoinObject.GetComponent<CoinScript>().type = 6;
                CoinObject.GetComponent<CoinScript>().maxhp = level * 500;
                CoinObject.GetComponent<CoinScript>().hp = level * 500;
                CoinObject.GetComponent<CoinScript>().level = level;
                CoinObject.GetComponent<CoinScript>().money = 2500 + level * 1250;
                CoinObject.GetComponent<SpriteRenderer>().sprite = CoinImages[6];
                break;
            case 7:
                CoinObject.GetComponent<CoinScript>().type = 7;
                CoinObject.GetComponent<CoinScript>().maxhp = level * 600;
                CoinObject.GetComponent<CoinScript>().hp = level * 600;
                CoinObject.GetComponent<CoinScript>().level = level;
                CoinObject.GetComponent<CoinScript>().money = 3000 + level * 1500;
                CoinObject.GetComponent<SpriteRenderer>().sprite = CoinImages[7];
                break;
            case 8:
                CoinObject.GetComponent<CoinScript>().type = 8;
                CoinObject.GetComponent<CoinScript>().maxhp = level * 800;
                CoinObject.GetComponent<CoinScript>().hp = level * 800;
                CoinObject.GetComponent<CoinScript>().level = level;
                CoinObject.GetComponent<CoinScript>().money = 4000 + level * 2000;
                CoinObject.GetComponent<SpriteRenderer>().sprite = CoinImages[8];
                break;
            case 9:
                CoinObject.GetComponent<CoinScript>().type = 9;
                CoinObject.GetComponent<CoinScript>().maxhp = level * 1000;
                CoinObject.GetComponent<CoinScript>().hp = level * 1000;
                CoinObject.GetComponent<CoinScript>().level = level;
                CoinObject.GetComponent<CoinScript>().money = 5000 + level * 5000;
                CoinObject.GetComponent<SpriteRenderer>().sprite = CoinImages[9];
                break;
            default:
                return;
        }

        DOSequence.AppendCallback(() =>
        {
            battleing = true;
            HealthBar.SetActive(true);
            HealthBar.transform.GetChild(0).GetComponent<RectTransform>().sizeDelta = new Vector2(1000, 100);

        });
    }

    public void ExitButton()
    {
        if (!battleing)
        {
            MainScene.SetActive(true);
            Webtoon.SetActive(true);

            return;
        }
        HealthBar.transform.GetChild(0).GetComponent<RectTransform>().sizeDelta = new Vector2(1000, 100);
        HealthBar.SetActive(false);
        Sequence DOSequence = DOTween.Sequence();
        DOSequence.Append(CoinObject.GetComponent<SpriteRenderer>().material.DOFade(0, 0.5f));
        DOSequence.Append(GraphicCards.transform.DOMove(new Vector2(0, 0f), 1f));
        DOSequence.Append(menus.transform.DOMove(menuPos, 1f));

        battleing = false;
    }
}
