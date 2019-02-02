using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Gold : MonoBehaviour {
    public Text GoldText = null;
    public int score,totalGold,gold,startingPoints;
    public Score scoreScript;

    void Awake()
    {
        totalGold =PlayerPrefs.GetInt("totalGold");
        startingPoints = scoreScript.startingPoints;
    }
    void Update () {
        score = scoreScript.score;
        GoldText.text = "GOLD : " + gold.ToString();
        gold = ((score- startingPoints) * 5);
        PlayerPrefs.SetInt("totalGold",totalGold+gold);
	
	}
}
