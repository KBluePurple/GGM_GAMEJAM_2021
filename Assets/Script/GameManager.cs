using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] GraphicCards;

    [SerializeField]
    Transform EnemyPosition;

    Sequence sequence = null;

    int CurruntCard = 0;

    int ClickCount = 0;

    public void AttackEnemy()
    {
        ClickCount++;

        if (sequence != null)
            sequence.Kill();
        sequence = DOTween.Sequence();

        CurruntCard = Random.Range(0, GraphicCards.Length);
        sequence.Append(GraphicCards[CurruntCard].transform.DOMove(EnemyPosition.position, 0.1f));
        sequence.AppendInterval(0.1f);
        sequence.Append(GraphicCards[CurruntCard].transform.DOMove(GraphicCards[CurruntCard].transform.parent.position, 0.1f));

        sequence.AppendCallback(() =>
        {
            
        });
    }

    public void Update()
    {
        if (ClickCount > 0)
        {

        }
    }
}
