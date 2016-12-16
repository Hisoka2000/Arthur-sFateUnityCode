using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text GameScore;
    public float ScoreNumber = 1;

    void Update()
    {
        if (Time.timeScale == 1)
        {
            ScoreNumber++;
            GameScore.text = (ScoreNumber).ToString();
        }
    }

}
