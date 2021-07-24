using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PopManager : MonoBehaviour
{
 
   

    public Transform reinforceError;

    public Button reinforceErrorBackturnbtn;

    public Transform SettingPopup;

    public Button CloseSettingPopup;

    void Start()
    {
        reinforceErrorBackturnbtn.onClick.AddListener(ReinforceErrorBackturn);
        reinforceError.localScale = Vector3.zero;
        CloseSettingPopup.onClick.AddListener(CloseSettingPopupF);
        SettingPopup.localScale = Vector3.zero;
    }

    public void ReinforceError()
    {
        reinforceError.gameObject.SetActive(true);
        Sequence seq = DOTween.Sequence();
        seq.Append(reinforceError.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 0.2f));
        seq.Append(reinforceError.DOScale(new Vector3(1f, 1f, 1f), 0.1f));
    }

    public void ReinforceErrorBackturn()
    {
        reinforceError.DOScale(new Vector3(0f, 0f, 0f), 0.2f);
    }

    public void OpenSettingPopupF()
    {
        SettingPopup.gameObject.SetActive(true);
        Sequence seq = DOTween.Sequence();
        seq.Append(SettingPopup.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 0.2f));
        seq.Append(SettingPopup.DOScale(new Vector3(1f, 1f, 1f), 0.1f));
    }

    public void CloseSettingPopupF()
    {
        SettingPopup.DOScale(new Vector3(0f, 0f, 0f), 0.2f);
    }
}
