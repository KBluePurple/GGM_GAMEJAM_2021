using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvManager : MonoBehaviour
{
    AttackManager attackManager = null;

    bool[] inv = new bool[10];
    bool[] cardInv = new bool[5];

    [SerializeField]
    Button[] matetials;

    [SerializeField]
    Button[] CraftButtons;

    [SerializeField]
    Button[] UpgradeButtons;

    public Button[] cards;

    void Start()
    {
        attackManager = FindObjectOfType<AttackManager>();
        AddItem(0);
        AddItem(1);
    }

    public void AddItem(int item)
    {
        inv[item] = true;
        matetials[item].interactable = true;
    }

    public bool CheckItem(int item)
    {
        return inv[item];
    }

    public void AddCard(int card)
    {
        CraftButtons[card].interactable = false;
        UpgradeButtons[card].interactable = true;
        card++;
        cardInv[card] = true;
        attackManager.GraphicCards[card].SetActive(true);
        attackManager.GraphicCards[card].GetComponent<GraphicCard>().IsUnlocked = true;
    }

    public bool CheckCard(int card)
    {
        return cardInv[card];
    }

    public void SaveItems()
    {
        string saveStr = "";
        for (int i = 0; i < 10; i++)
        {
            if (inv[i])
            {
                saveStr += "1";
            }
            else
                saveStr += "0";
        }
        PlayerPrefs.SetString("Items", saveStr);

        saveStr = "";
        for (int i = 0; i < 5; i++)
        {
            if (cardInv[i])
            {
                saveStr += "1";
            }
            else
                saveStr += "0";
        }
        PlayerPrefs.SetString("Cards", saveStr);
    }

    public void LoadItems()
    {
        string saveStr = PlayerPrefs.GetString("Items", "0000000000");
        for (int i = 0; i < 10; i++)
        {
            if (saveStr.ToCharArray()[i] == '1')
            {
                inv[i] = true;
                matetials[i].interactable = true;
            }
            else
                inv[i] = false;
        }

        saveStr = PlayerPrefs.GetString("Items", "10000");
        for (int i = 0; i < 5; i++)
        {
            if (saveStr.ToCharArray()[i] == '1')
            {
                AddCard(i);
            }
            else
                cardInv[i] = false;
        }
    }
}
