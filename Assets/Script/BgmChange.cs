using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  플레이어의 tag 속성을 'myplayer'로 지어주거나, 아래의 소스를 변경해 주시면 됩니다.

public class BgmChange : MonoBehaviour
{
    // Inspector 영역에 표시할 배경음악 이름
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