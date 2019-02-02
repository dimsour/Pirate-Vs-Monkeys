using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class monkeyHealthBar2 : MonoBehaviour {

    public int mHealth;

    public monkey tempHealth;
    public Image[] healthImage;
    public bool blackMonkey;


    void Update() {

        mHealth = tempHealth.tempHealth;
        blackMonkey = tempHealth.blackMonkey;
        if (!blackMonkey)
        {
            if (mHealth == 2)
            {
                healthImage[2].enabled = true;
                healthImage[1].enabled = false;
                healthImage[0].enabled = false;
            }
            else if (mHealth == 1)
            {
                healthImage[2].enabled = false;
                healthImage[1].enabled = true;
                healthImage[0].enabled = false;
            }
            else if (mHealth == 0)
            {
                healthImage[2].enabled = false;
                healthImage[1].enabled = false;
                healthImage[0].enabled = true;
            }
        }
        else
        {
            if (mHealth == 3)
            {
                healthImage[3].enabled = true;
                healthImage[2].enabled = false;
                healthImage[1].enabled = false;
                healthImage[0].enabled = false;
            }
            if (mHealth == 2)
            {
                healthImage[3].enabled = false;
                healthImage[2].enabled = true;
                healthImage[1].enabled = false;
                healthImage[0].enabled = false;
            }
            else if (mHealth == 1)
            {
                healthImage[3].enabled = false;
                healthImage[2].enabled = false;
                healthImage[1].enabled = true;
                healthImage[0].enabled = false;
            }
            else if (mHealth == 0)
            {
                healthImage[3].enabled = false;
                healthImage[2].enabled = false;
                healthImage[1].enabled = false;
                healthImage[0].enabled = true;
            }
        }

    }
}
