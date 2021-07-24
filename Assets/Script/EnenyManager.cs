using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenyManager : MonoBehaviour
{
    public double enemyLevel = 1;
    double[] enemyHp = new double[] { 10, 50, 100, 250, 300, 400, 500, 600, 800, 1000};

    public void BiteHpCheck()
    {
        enemyHp[0] = enemyLevel * 10;
    }

    public void PopCatHpCheck()
    {
        enemyHp[1] = enemyLevel * 50;
    }
    public void GgmHpCheck()
    {
        enemyHp[2] = enemyLevel * 100;
    }
    public void ThreethereumHpCheck()
    {
        enemyHp[3] = enemyLevel * 250;
    }
    public void CyberPunkHpCheck()
    {
        enemyHp[4] = enemyLevel * 300;
    }
    public void DonxenHpCheck()
    {
        enemyHp[5] = enemyLevel * 400;
    }
    public void PlayShopHpCheck()
    {
        enemyHp[6] = enemyLevel * 500;
    }
    public void UnityHpCheck()
    {
        enemyHp[7] = enemyLevel * 600;
    }
    public void RealHpCheck()
    {
        enemyHp[8] = enemyLevel * 800;
    }
    public void SteamHpCheck()
    {
        enemyHp[9] = enemyLevel * 1000;
    }
}
