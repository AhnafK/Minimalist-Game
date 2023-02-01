using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatchPlayer : MonoBehaviour
{
    public Score UI;

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            UI.penalty();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
