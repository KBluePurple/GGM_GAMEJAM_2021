using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AttackManager : MonoBehaviour
{
    public GameObject[] GraphicCards;
    [SerializeField]
    Transform EnemyPosition;
    [SerializeField]
    GameObject coinObject = null;

    int clickCount = 0;

    GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    public void Attack()
    {
        if (gameManager.battleing)
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
                if (!GraphicCards[i].GetComponent<GraphicCard>().IsAttacking && GraphicCards[i].GetComponent<GraphicCard>().IsUnlocked)
                    idleCard.Add(GraphicCards[i]);
            }

            if (idleCard.Count > 0)
            {
                int selectedCard = Random.Range(0, idleCard.Count);
                idleCard[selectedCard].GetComponent<GraphicCard>().IsAttacking = true;

                DOSequence.Append(idleCard[selectedCard].transform.DOMove(EnemyPosition.position, 0.1f));

                DOSequence.AppendCallback(() =>
                {
                    coinObject.GetComponent<CoinScript>().damaged(idleCard[selectedCard].GetComponent<GraphicCard>().damage);
                });

                DOSequence.Append(idleCard[selectedCard].transform.DOMove(new Vector3(0, 0, 0) + idleCard[selectedCard].transform.parent.position, 0.1f));
                Camera.main.GetComponent<ShakeCamera>().VibrateForTime(0.2f);

                DOSequence.InsertCallback(0.2f, () =>
                {
                    idleCard[selectedCard].GetComponent<GraphicCard>().IsAttacking = false;
                });
            }
            clickCount--;
        }
    }
}
