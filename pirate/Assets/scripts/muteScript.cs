using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class muteScript : MonoBehaviour
{

    public GameObject[] icons;
    int mute;

    public void Update()
    {
        
        mute = PlayerPrefs.GetInt("mute");
        if (mute==0)
        {
            icons[0].SetActive(true);
            icons[1].SetActive(false);
            //print("isPlaying");
        }
        else //if(!mainAudio.isPlaying)
        {

            icons[0].SetActive(false);
            icons[1].SetActive(true);
            //print("isNotPlaying");
        }
    }
    public void muteButton()
    {
        if (mute==0)
        {
            PlayerPrefs.SetInt("mute",1);
        }
        else
        {
            PlayerPrefs.SetInt("mute", 0);
        }
    }
}
