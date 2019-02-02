using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class swordBuy : MonoBehaviour
{

    public bool bought, equipted, firstWeap;
    public Text swordText;
    public int swordNumber;
    public int price;
    public string swordNumberString;

    void Update()
    {
        if (PlayerPrefs.GetInt(swordNumberString) == 1)
        {
            bought = true;
        }

        if (swordNumber == PlayerPrefs.GetInt("swordNumber"))
        {
            equipted = true;
            swordText.text = "equipped";
        }
        else if (bought)
        {
            swordText.text = "Equipt";
        }
        else
        {
            if (!firstWeap)
                swordText.text = "Buy : " + price;
        }
        if (firstWeap && PlayerPrefs.GetInt("swordNumber") ==0)
        {
            swordText.text = "equippted";
        }


    }
}
