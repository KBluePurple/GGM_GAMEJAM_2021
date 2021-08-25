using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvManager : MonoBehaviour
{
    [SerializeField]
    Button[] materials;
    [SerializeField]
    Button[] CraftButtons;
    [SerializeField]
    Button[] UpgradeButtons;
    ReinforceUIManager reinforceUIManager = null;
    AttackManager attackManager = null;
    public Inventory inventory;
    public Button[] cards;
    UIManager uIManager;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        uIManager = FindObjectOfType<UIManager>();
        attackManager = FindObjectOfType<AttackManager>();
        reinforceUIManager = FindObjectOfType<ReinforceUIManager>();
        LoadItems();
    }

    public void AddItem(int item)
    {
        Debug.Log(item);
        inventory.inv[item] = true;
        materials[item].interactable = true;
        SaveItems();
    }

    public bool CheckItem(int item)
    {
        return inventory.inv[item];
    }

    public void AddCard(int card)
    {
        CraftButtons[card].interactable = false;
        UpgradeButtons[card].interactable = true;
        card++;
        inventory.cardInv[card] = true;
        attackManager.GraphicCards[card].SetActive(true);
        attackManager.GraphicCards[card].GetComponent<GraphicCard>().IsUnlocked = true;
        SaveItems();
    }

    public bool CheckCard(int card)
    {
        return inventory.cardInv[card];
    }

    public void SaveItems()
    {
        Debug.Log("[Save] " + JsonUtility.ToJson(inventory));
        PlayerPrefs.SetString("Inventory", JsonUtility.ToJson(inventory));
    }

    public void LoadItems()
    {
        Debug.Log("[Load] " + PlayerPrefs.GetString("Inventory", ""));
        inventory = JsonUtility.FromJson<Inventory>(PlayerPrefs.GetString("Inventory", ""));
        if(inventory == null)
        {
            inventory = new Inventory();
        }

        for(int i = 0; i < 5; i++)
        {
            Debug.Log("card +" + inventory.cardInv[i]);
            if(inventory.cardInv[i] == true)
                AddCard(i-1);
        }

        for(int i = 0; i < 10; i++)
        {
            if(inventory.inv[i])
                AddItem(i);
        }

        for(int i = 0; i < 5; i++)
        {
            if (inventory.rainforceLevel[i] >= 25)
                inventory.rainforceLevel[i] = 25;
            
            for(int j = 0; j < inventory.rainforceLevel[i]; j++)
            {
                switch(i + 1)
                {
                    case 1:
                        reinforceUIManager.GraphicCards[0].levelUp();
                        reinforceUIManager.reinforcecost[0] *= 100;
                        break;
                    case 2:
                        reinforceUIManager.GraphicCards[1].levelUp();
                        reinforceUIManager.reinforcecost[1] *= 500;
                        break;
                    case 3:
                        reinforceUIManager.GraphicCards[2].levelUp();
                        reinforceUIManager.reinforcecost[2] *= 1000;
                        break;
                    case 4:
                        reinforceUIManager.GraphicCards[3].levelUp();
                        reinforceUIManager.reinforcecost[3] *= 2500;
                        break;
                    case 5:
                        reinforceUIManager.GraphicCards[4].levelUp();
                        reinforceUIManager.reinforcecost[4] *= 5000;
                        break;
                }
            }
        }
        uIManager.UpdateUI();
        Debug.Log("[Loaded] " + JsonUtility.ToJson(inventory));
    }
}
