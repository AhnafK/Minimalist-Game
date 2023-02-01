using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    void Update() {
        if (Input.GetKeyDown("space")) {
            SceneManager.LoadScene(1);
            PlayerPrefs.SetInt("score", 0);
        }
    }
}
