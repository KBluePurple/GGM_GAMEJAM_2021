using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PopManager : MonoBehaviour
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

        //DOTween.To(����, ����, ������, �Ⱓ);
        ///DOTween.To(() => cvsGroup.alpha, v => cvsGroup.alpha = v, 1, 2.5f);
    }

    public void ReinforceErrorBackturn()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(reinforceError.DOScale(new Vector3(0f, 0f, 0f), 0.2f));
    }

    


    /*
     public Transform makingError;

    public Button makingBackturnbtn;




    makingBackturnbtn.onClick.AddListener(makingBackturn);
        makingError.localScale = Vector3.zero;



    public void makingError()
    {
        makingError.gameObject.SetActive(true);
        Sequence seq = DOTween.Sequence();
        seq.Append(makingError.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 0.2f));
        seq.Append(makingError.DOScale(new Vector3(1f, 1f, 1f), 0.1f));

        //DOTween.To(����, ����, ������, �Ⱓ);
        ///DOTween.To(() => cvsGroup.alpha, v => cvsGroup.alpha = v, 1, 2.5f);
    }

    public void makingBackturn()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(makingError.DOScale(new Vector3(0f, 0f, 0f), 0.2f));
    }
    */
}
