using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public bool launch = false;
    public float yPos;
    float change;

    void Update() {
        if (launch) {
            if (yPos <= 1f) {
                change = 1f;
            } else if (yPos >= 2f) {
                change = -1f;
            }
            yPos += change * Time.deltaTime;
            transform.localPosition = new Vector3(0, yPos, 0);
        } else {
            yPos = 1f;
            transform.localPosition = new Vector3(0, 1, 0);
        }
    }
}
