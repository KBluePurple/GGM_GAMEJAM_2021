using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PopManager : MonoBehaviour
{
    public Button reinforceErrorbtn;

    public Transform reinforceError;

    public Button reinforceErrorBackturnbtn;

    public CanvasGroup cvsGroup;
    void Start()
    {
        reinforceErrorbtn.onClick.AddListener(ReinforceError);
        reinforceErrorBackturnbtn.onClick.AddListener(ReinforceErrorBackturn);
        reinforceError.localScale = Vector3.zero;
        cvsGroup = reinforceError.GetComponent<CanvasGroup>();
    }

    public void ReinforceError()
    {
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
