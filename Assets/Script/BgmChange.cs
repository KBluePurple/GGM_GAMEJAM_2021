using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  �÷��̾��� tag �Ӽ��� 'myplayer'�� �����ְų�, �Ʒ��� �ҽ��� ������ �ֽø� �˴ϴ�.

public class BgmChange : MonoBehaviour
{
    // Inspector ������ ǥ���� ������� �̸�
    public string bgmName = "";

    private GameObject CamObject;

    void Start()
    {
        CamObject = GameObject.Find("Main Camera");
    }

    public void OnClickMainBGM()
    {
        CamObject.GetComponent<PlayMusicOperator>().PlayBGM(bgmName);
    }
}