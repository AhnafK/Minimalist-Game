using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawner : MonoBehaviour
{
    public Points point;
    public ChasePlayer Enemy;
    public Transform playerPos;
    public float width;
    public float height;
    int number = 5;

    public Score score;

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount == 0)
        {
            for (int i = 0; i < number; i++)
            {
                Vector3 newSpawn = new Vector3(Random.Range(-width / 2, width/2), Random.Range(-height / 2, height / 2), 0);
                Points newpoint = Instantiate(point, transform);
                newpoint.transform.position = newSpawn;
                newpoint.score = score;
            }
            number += 1;

            if (number > 6)
            {
                ChasePlayer newEnemy = Instantiate(Enemy, new Vector3(-7, Random.Range(-height / 2, height / 2), 0), Quaternion.identity);
                if (newEnemy.speed < 1.2)
                {
                    newEnemy.speed += 0.1f;
                }
            }
        }
    }
}
