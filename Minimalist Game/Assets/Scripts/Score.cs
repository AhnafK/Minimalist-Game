using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI strikeText;
    int currentScore = 0;
    int stroke = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + currentScore.ToString(); 
        strikeText.text = "Stroke " + stroke.ToString();
    }

    public void Increment(int points) {
        currentScore += points;
    }

    public void Strike() {
        stroke += 1;
    }

    public void calculateScore() {
        currentScore += 1000 * (5 - stroke);
        // change 5 to par amount per course
        Debug.Log(currentScore);
    }
}
