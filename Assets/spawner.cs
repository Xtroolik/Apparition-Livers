using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Sets variables for later use
    public GameObject Enemy;
    public float interval = 100;
    private float counter = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Counter goes up every second
        counter += 1;
        // If counter goes above or equates interval summon the enemy
        if (counter >= interval)
        {
            counter = 0;
            Instantiate(Enemy, transform.position, transform.rotation);

        }
    }
}