using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    GameObject MainScene;


    public void OnclickStart()
    {
        gameObject.SetActive(false);
    }

    public void OnClickBack()
    {
        gameObject.SetActive(false);
    }
    
    public void OnclickHelp()
    {
        gameObject.SetActive(true);
    }

    public void OnClickQuit()
    {
        Application.Quit();
#if !UINTY_EDITOR
        System.Diagnostics.Process.GetCurrentProcess().Kill();
#endif
    }
}
