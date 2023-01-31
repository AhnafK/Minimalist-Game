using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    int currentScore = 0;
    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + currentScore.ToString(); 
    }

    public void Increment(int points) {
        currentScore += points;
    }
}
