using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftManager : MonoBehaviour
{
    InvManager invManager = null;

    MakingPopManager MakingPopManager = null;


    public void Craft1()
    {
        Craft(0);
    }

    public void Craft2()
    {
        Craft(1);
    }

    public void Craft3()
    {
        Craft(2);
    }

    public void Craft4()
    {
        Craft(3);
    }

    void Start()
    {
        invManager = FindObjectOfType<InvManager>();
        MakingPopManager = FindObjectOfType<MakingPopManager>();
    }

    void FaildUpgrade()
    {
        MakingPopManager.ReinforceError();
    }

    bool Craft(int card)
    {
        switch(card)
        {
            case 0:
                if (invManager.CheckItem(0) && invManager.CheckItem(1))
                {
                    invManager.AddCard(0);
                    return true;
                }
                else
                {
                    FaildUpgrade();
                }
                break;
            case 1:
                if (invManager.CheckItem(2) && invManager.CheckItem(3))
                {
                    invManager.AddCard(1);
                    return true;
                }
                else
                {
                    FaildUpgrade();
                }
                break;
            case 2:
                if (invManager.CheckItem(4) && invManager.CheckItem(5) && invManager.CheckItem(6))
                {
                    invManager.AddCard(2);
                    return true;
                }
                else
                {
                    FaildUpgrade();
                }
                break;
            case 3:
                if (invManager.CheckItem(7) && invManager.CheckItem(8) && invManager.CheckItem(9))
                {
                    invManager.AddCard(3);
                    return true;
                }
                else
                {
                    FaildUpgrade();
                }
                break;
        }
        Debug.Log(card);
        return false;
    }
}
