using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MakingPopManager : MonoBehaviour
{
    public Transform reinforceError;

    public Button reinforceErrorBackturnbtn;


    void Start()
    {
        reinforceErrorBackturnbtn.onClick.AddListener(ReinforceErrorBackturn);
        reinforceError.localScale = Vector3.zero;


    }

    public void ReinforceError()
    {
        reinforceError.gameObject.SetActive(true);
        Sequence seq = DOTween.Sequence();
        seq.Append(reinforceError.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 0.2f));
        seq.Append(reinforceError.DOScale(new Vector3(1f, 1f, 1f), 0.1f));

        //DOTween.To(겟터, 셋터, 최종값, 기간);
        ///DOTween.To(() => cvsGroup.alpha, v => cvsGroup.alpha = v, 1, 2.5f);
    }

    public void ReinforceErrorBackturn()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(reinforceError.DOScale(new Vector3(0f, 0f, 0f), 0.2f));
    }
}
