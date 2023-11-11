using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public Text Score;
    int myScore = 0;

    void Update()
    {
        Score.text = myScore.ToString();
    }
    public void AddScore(int score)
    {
        myScore = myScore + score;
    }
}
