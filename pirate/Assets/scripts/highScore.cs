using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class highScore : MonoBehaviour
{
    public int highScore1;

    public Text highScoreText = null;

    public void Start()
    {
        ZPlayerPrefs.Initialize("h@takeKak@sh114", "h@takeKak@sh1");
        highScoreText.text = "HIGHSCORE :" + ZPlayerPrefs.GetFloat("highscore");
    }
}