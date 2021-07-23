using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicCard : MonoBehaviour
{
    [SerializeField]
    float upgradeValue = 1;
    [SerializeField]
    float damage = 0;

    public int level = 1;

    public bool IsAttacking = false;

    public void levelUp()
    {
        level++;
        damage += upgradeValue;
    }
}
