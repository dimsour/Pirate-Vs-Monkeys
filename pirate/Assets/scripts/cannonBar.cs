using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cannonBar : MonoBehaviour {

    public shipClick shipClickScript;
    public Text text;
    public Image fill;
    public Image cannonSprite;

    public float seconds;
    public int numberOfBalls;


    void Update () {
        numberOfBalls = PlayerPrefs.GetInt("numberOfBalls");
        seconds = shipClickScript.timer;
        text.text = "x" + numberOfBalls.ToString();
        if(seconds<5 && numberOfBalls>0)
        {
            cannonSprite.GetComponent<Image>().color = new Color32(255, 255, 255, 180);
            fill.fillAmount = seconds / 5;
            GetComponent<AudioSource>().enabled = false;
        }
        else if(seconds==5 && numberOfBalls>0)
        {
            cannonSprite.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GetComponent<AudioSource>().enabled = true;
        }

	}
}
