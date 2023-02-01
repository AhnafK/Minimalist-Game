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
    public float delay = 1/20f;
    public Launch triangle;
    public GameObject pointer;
    public Score strikeText;
    public Rigidbody2D rb;

    bool spinning = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && aim) {
            launch = true;
            aim = false;
            spinning = false;
            triangle.launch = true;
        } else if (Input.GetKeyUp("space") && launch) {
            rb.AddForce(transform.up * launchForce * Mathf.Pow(triangle.yPos, 3));
            Debug.Log("launch");
            rb.freezeRotation = true;
            Invoke("SetLaunchFalse", delay);
            triangle.launch = false;
            pointer.GetComponent<Renderer>().enabled = false;
            strikeText.Strike();
        }

        if (rb.velocity.magnitude < minSpeed && !launch) {
            rb.velocity = Vector2.zero;
            aim = true;
            speed = 120f*(1+Mathf.Floor(Random.Range(0,2)));
            if(Random.Range(0,1) < 0.5)
            {
                speed *= -1;
            }
            spinning = true;
            rb.freezeRotation = false;
            pointer.GetComponent<Renderer>().enabled = true;
        }

        if (aim && spinning) {
            transform.Rotate(0,0, speed*Time.deltaTime);
        }
    }

    void SetLaunchFalse() {
        launch = false;
    }
}
