using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenyManager : MonoBehaviour
{
    public double enemyLevel = 1;
    double[] enemyHp = new double[] { 1, 50, 100, 250, 300, 400, 500, 600, 800, 1000};

    public void EnemmyOneHpCheck()
    {
        enemyHp[0] = enemyLevel * 10;
    }

    public void EnemmyTwoHpCheck()
    {
        enemyHp[1] = enemyLevel * 50;
    }
    public void EnemmyThreeHpCheck()
    {
        enemyHp[2] = enemyLevel * 100;
    }
    public void EnemmyFourHpCheck()
    {
        enemyHp[3] = enemyLevel * 250;
    }
    public void EnemmyFiveHpCheck()
    {
        enemyHp[4] = enemyLevel * 300;
    }
    public void EnemmySixHpCheck()
    {
        enemyHp[5] = enemyLevel * 400;
    }
    public void EnemmySevenHpCheck()
    {
        enemyHp[6] = enemyLevel * 500;
    }
    public void EnemmyEightHpCheck()
    {
        enemyHp[7] = enemyLevel * 600;
    }
    public void EnemmyNineHpCheck()
    {
        enemyHp[8] = enemyLevel * 800;
    }
    public void EnemmyTenHpCheck()
    {
        enemyHp[9] = enemyLevel * 1000;
    }
}
