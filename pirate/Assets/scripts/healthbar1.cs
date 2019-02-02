using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class healthbar1 : MonoBehaviour {

    public int health;
   

    public Image[] healthImage;
    public Health pirateHealth;
    

    void Update () {

        health = pirateHealth.health;
       
        if (health==3)
        {
            healthImage[3].enabled = true;
            healthImage[2].enabled = false;
            healthImage[1].enabled = false;
            healthImage[0].enabled = false;
        }
        else if (health == 2)
        {
            healthImage[2].enabled = true;
            healthImage[3].enabled = false;
            healthImage[1].enabled = false;
            healthImage[0].enabled = false;
        }
        else if (health == 1)
        {
            healthImage[1].enabled = true;
            healthImage[2].enabled = false;
            healthImage[3].enabled = false;
            healthImage[0].enabled = false;
        }
        else if (health == 0)
        {
            healthImage[0].enabled = true;
            healthImage[1].enabled = false;
            healthImage[2].enabled = false;
            healthImage[3].enabled = false;
        }
    }
}
