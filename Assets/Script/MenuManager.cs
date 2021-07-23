using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] Menus;

    int CurrentMenu = 0;

    private void Start()
    {
        for(int i = 0; i < Menus.Length; i++)
            Menus[i].SetActive(false);
        Menus[CurrentMenu].SetActive(true);
    }

    public void ChangeMenu1()
    {
        Menus[CurrentMenu].SetActive(false);
        CurrentMenu = 0;
        Menus[CurrentMenu].SetActive(true);
    }
    public void ChangeMenu2()
    {
        Menus[CurrentMenu].SetActive(false);
        CurrentMenu = 1;
        Menus[CurrentMenu].SetActive(true);
    }
    public void ChangeMenu3()
    {
        Menus[CurrentMenu].SetActive(false);
        CurrentMenu = 2;
        Menus[CurrentMenu].SetActive(true);
    }
    public void ChangeMenu4()
    {
        Menus[CurrentMenu].SetActive(false);
        CurrentMenu = 3;
        Menus[CurrentMenu].SetActive(true);
    }
}
