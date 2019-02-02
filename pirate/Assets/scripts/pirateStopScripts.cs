using UnityEngine;
using System.Collections;

public class pirateStopScripts : MonoBehaviour
{

    public Health pirateHealth;
    int health;

    void Update()
    {
        health = pirateHealth.health;
        if (health <= 0)
        {
            GetComponent<flip>().enabled = false;
        }
    }
}
