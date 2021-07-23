using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int level = 0;
    public int hp = 0;
    
    public void damaged(int damage)
    {
        hp -= damage;
    }
}
