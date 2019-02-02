using UnityEngine;
using System.Collections;

public class gunStopScripts : MonoBehaviour
{
    public Health pirateHealth;
    int health;

    void Update()
    {
        health = pirateHealth.health;
        if (health == 0)
        {
            GetComponent<Shoot >().enabled = false;
            GetComponent<armAngle>().enabled = false;
        }
        else
        {
          GetComponent<Shoot>().enabled = true;
          GetComponent<armAngle>().enabled = true;
        }
    }
}
