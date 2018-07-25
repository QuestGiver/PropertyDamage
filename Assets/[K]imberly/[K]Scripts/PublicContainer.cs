using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PublicContainer
{
    private static int score;
    public static int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            PointsUI.instance.UpdateUI(score);
        }
    }
}
