using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicCard : MonoBehaviour
{
    [SerializeField]
    int upgradeValue = 1;
    
    public int damage = 0;

    public int level = 1;

    public bool IsAttacking = false;

    public void levelUp()
    {
        level++;
        damage += upgradeValue;
    }
}
