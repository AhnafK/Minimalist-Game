using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    bool aim = true;
    [SerializeField]
    bool launch = false;
    float speedSquare;
    [SerializeField]
    float minSpeed;
    public float speed = 120f;
    public float launchForce;
    public Launch triangle;
    public GameObject pointer;
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
            rb.AddForce(transform.up * launchForce * Mathf.Pow(triangle.yPos, 3));
            Debug.Log("launch");
            rb.freezeRotation = true;
            Invoke("SetLaunchFalse", 1f);
            triangle.launch = false;
            pointer.GetComponent<Renderer>().enabled = false;
        }

        speedSquare = Mathf.Pow(rb.velocity.x, 2) + Mathf.Pow(rb.velocity.y, 2);
        if (Mathf.Sqrt(speedSquare) < minSpeed && !launch) {
            aim = true;
            speed = 120f;
            rb.freezeRotation = false;
            pointer.GetComponent<Renderer>().enabled = true;
        }

        if (aim) {
            transform.Rotate(0,0, speed*Time.deltaTime);
        }
    }

    void SetLaunchFalse() {
        launch = false;
    }
}
