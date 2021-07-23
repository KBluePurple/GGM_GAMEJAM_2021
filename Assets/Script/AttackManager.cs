using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AttackManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] GraphicCards;
    [SerializeField]
    Transform EnemyPosition;
    [SerializeField]
    Camera uiCamera = null;
    int clickCount = 0;


    public void Attack()
    {
        clickCount++;
    }

    private void Update()
    {
        if (clickCount > 0)
        {
            Sequence DOSequence = DOTween.Sequence();
            List<GameObject> idleCard = new List<GameObject>();
            for (int i = 0; i < GraphicCards.Length; i++)
            {
                if (!GraphicCards[i].GetComponent<GraphicCard>().IsAttacking)
                    idleCard.Add(GraphicCards[i]);
            }

            int selectedCard = Random.Range(0, idleCard.Count);
            idleCard[selectedCard].GetComponent<GraphicCard>().IsAttacking = true;

            DOSequence.Append(idleCard[selectedCard].transform.DOMove(EnemyPosition.position, 0.1f));
            DOSequence.AppendInterval(0.1f);
            DOSequence.Append(idleCard[selectedCard].transform.DOMove(new Vector3(0, 0, 0) + idleCard[selectedCard].transform.parent.position, 0.1f));
            Camera.main.GetComponent<ShakeCamera>().VibrateForTime(0.1f);

            DOSequence.InsertCallback(0.3f, () =>
            {
                idleCard[selectedCard].GetComponent<GraphicCard>().IsAttacking = false;
                DOSequence.Kill();
            });

            clickCount--;
        }
    }
}
