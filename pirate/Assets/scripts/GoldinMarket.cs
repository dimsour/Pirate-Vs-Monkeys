using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoldinMarket : MonoBehaviour {
    public Text TotalGoldText = null;


    void Update () {
        TotalGoldText.text = "Total GOLD :" + PlayerPrefs.GetInt("totalGold");

    }
}
