using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] Menus;

    int CurrentMenu = 0;

    AudioManager audioManager = null;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        for(int i = 0; i < Menus.Length; i++)
            Menus[i].SetActive(false);
        Menus[CurrentMenu].SetActive(true);
    }

    public void ChangeMenu1()
    {
        Menus[CurrentMenu].SetActive(false);
        CurrentMenu = 0;
        audioManager.PlaySound("CHOOSE");
        Menus[CurrentMenu].SetActive(true);
    }
    public void ChangeMenu2()
    {
        Menus[CurrentMenu].SetActive(false);
        CurrentMenu = 1;
        audioManager.PlaySound("CHOOSE");
        Menus[CurrentMenu].SetActive(true);
    }
    public void ChangeMenu3()
    {
        Menus[CurrentMenu].SetActive(false);
        CurrentMenu = 2;
        audioManager.PlaySound("CHOOSE");
        Menus[CurrentMenu].SetActive(true);
    }
    public void ChangeMenu4()
    {
        Menus[CurrentMenu].SetActive(false);
        CurrentMenu = 3;
        audioManager.PlaySound("CHOOSE");
        Menus[CurrentMenu].SetActive(true);
    }
}
