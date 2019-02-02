using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gunBuy : MonoBehaviour
{

    public bool bought, equipted,firstWeap;
    public Text gunText;
    public int gunNumber;
    public int price;
    public string gunNumberString;

    void Update()
    {
        if(PlayerPrefs.GetInt(gunNumberString)==1)
        {
            bought = true;
        }

        if (gunNumber == PlayerPrefs.GetInt("gunNumber"))
        {
            equipted = true;
            gunText.text = "equipped";
        }
        else if(bought)
        {
            gunText.text = "Equipt";
        }
        else
        {
            if(!firstWeap)
            gunText.text = "Buy : " + price ;
        }
        if(firstWeap&&PlayerPrefs.GetInt("gunNumber")==0)
        {
            gunText.text = "equippted";
        }
       

    }
}
