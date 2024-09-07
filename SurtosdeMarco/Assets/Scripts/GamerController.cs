using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamerController : MonoBehaviour
{

    public int totalScore;
    public Text scoreText;

    public static GamerController instance;
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }


}
