using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField]
    int point;
    public Score score;
    
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player") {
            score.Increment(point);
            Destroy(gameObject);
        }
    }
}
