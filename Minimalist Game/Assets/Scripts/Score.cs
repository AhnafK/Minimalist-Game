using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI strikeText;
    public TextMeshProUGUI parText;
    int par;
    int currentScore = 0;
    int strike = 0;

    void Start() {
        Scene scene = SceneManager.GetActiveScene();
        //if (scene.name == "Level 1") {
        //    par = 5;
        //} else {
        //    par = 10;
        //}
        //parText.text = "Par " + par;
        currentScore = PlayerPrefs.GetInt("score");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.text = "Score: " + currentScore.ToString(); 
        strikeText.text = "Strike " + strike.ToString();
    }

    public void Increment(int points) {
        currentScore += points;
    }

    public void Strike() {
        strike += 1;
        currentScore -= 50;
    }

    public void calculateScore() {
        currentScore += 1000;// * (par - strike);
        // change 5 to par amount per course
        Debug.Log(currentScore);
        PlayerPrefs.SetInt("score", currentScore);
    }
}
