using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    bool aim = true;
    [SerializeField]
    bool launch = false;
    public float speed = 120f;
    public float launchForce;
    public Launch triangle;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && aim) {
            launch = true;
            aim = false;
            speed = 0f;
            triangle.launch = true;
        } else if (Input.GetKeyDown("space") && launch) {
            rb.AddForce(transform.up * launchForce * triangle.yPos);
            Debug.Log("launch");
            rb.freezeRotation = true;
            Invoke("SetLaunchFalse", 1f);
            triangle.launch = false;
        }

        if (rb.velocity == new Vector2(0.0f, 0.0f) && !launch) {
            aim = true;
            speed = 120f;
            rb.freezeRotation = false;
        }

        if (aim) {
            transform.Rotate(0,0, speed*Time.deltaTime);
        }
    }

    void SetLaunchFalse() {
        launch = false;
    }
}
