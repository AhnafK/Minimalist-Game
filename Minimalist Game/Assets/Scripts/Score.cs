using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI strikeText;
    int currentScore = 0;
    int strike = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + currentScore.ToString(); 
        strikeText.text = "Strike " + strike.ToString();
    }

    public void Increment(int points) {
        currentScore += points;
    }

    public void Strike() {
        strike += 1;
    }

    public void calculateScore() {
        currentScore += 1000 * (5 - strike);
        // change 5 to par amount per course
        Debug.Log(currentScore);
    }
}
