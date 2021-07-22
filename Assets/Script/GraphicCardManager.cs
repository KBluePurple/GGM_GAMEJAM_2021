using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicCardManager : MonoBehaviour
{
    public double graphicCard1Level = 1;
    public double graphicCard1Damage = 1;

    public double graphicCard2Level = 1;
    public double graphicCard2Damage = 2.5;

    public double graphicCard3Level = 1;
    public double graphicCard3Damage = 5;

    public double graphicCard4Level = 1;
    public double graphicCard4Damage = 10;

    public double graphicCard5Level = 1;
    public double graphicCard5Damage = 25;

    public void LevelUp1()
    {
        graphicCard1Level += 1;
        graphicCard1Damage += 1;
    }

    public void LevelUp2()
    {
        graphicCard2Level += 1;
        graphicCard2Damage += 2.5;
    }
    public void LevelUp3()
    {
        graphicCard3Level += 1;
        graphicCard3Damage += 5;
    }
    public void LevelUp4()
    {
        graphicCard4Level += 1;
        graphicCard4Damage += 10;
    }
    public void LevelUp5()
    {
        graphicCard5Level += 1;
        graphicCard5Damage += 25;
    }
}
