using UnityEngine;
using System.Collections;

public class storeScriptGuns : MonoBehaviour {

    public int gunNumber,gold;
    public int price2, price3, price4;
    public gunBuy gunBuyScript2,gunBuyScript3,gunBuyScript4;
    public bool gun2bought, gun3bought, gun4bought;
    public GameObject noGold;

    void Start()
    {
        price2 = gunBuyScript2.price;
        price3 = gunBuyScript3.price;
        price4 = gunBuyScript4.price;
    }
    void Update()
    {
        gold = PlayerPrefs.GetInt("totalGold");
    }
    public void gun1()
    {
        gunNumber = 1;
        PlayerPrefs.SetInt("gunNumber",gunNumber);
    }
    public void gun2()
    {
        if(!gunBuyScript2.bought)
        {
            if (gold >= gunBuyScript2.price)
            {
                PlayerPrefs.SetInt("totalGold", gold - price2);
                gunBuyScript2.bought = true;
                PlayerPrefs.SetInt("gun2", 1);
                print("boughttt");
            }
            else if (gold < gunBuyScript2.price)
            {
                noGold.SetActive(true);
                StartCoroutine(turnoff());
            }
        }
        if (gunBuyScript2.bought)
        {
            gunNumber = 2;
            PlayerPrefs.SetInt("gunNumber", gunNumber);
            print("equipted");
        }
    }
    public void gun3()
    {
        if (!gunBuyScript3.bought)
        {
            if (gold >= gunBuyScript3.price)
            {
                PlayerPrefs.SetInt("totalGold", gold - price3);
                gunBuyScript3.bought = true;
                PlayerPrefs.SetInt("gun3", 1);
            }
            else if (gold < gunBuyScript3.price)
            {
                noGold.SetActive(true);
                StartCoroutine(turnoff());
            }
        }
        if (gunBuyScript3.bought)
        {
            gunNumber = 3;
            PlayerPrefs.SetInt("gunNumber", gunNumber);
        }  
    }
    public void gun4()
    {
        if (!gunBuyScript4.bought)
        {
            if (gold >= gunBuyScript4.price)
            {
                PlayerPrefs.SetInt("totalGold", gold - price4);
                gunBuyScript4.bought = true;
                PlayerPrefs.SetInt("gun4", 1);
            }
            else if (gold < gunBuyScript4.price)
            {
                noGold.SetActive(true);
              StartCoroutine(turnoff());
            }
        }
        if(gunBuyScript4.bought)
        {
            gunNumber = 4;
            PlayerPrefs.SetInt("gunNumber", gunNumber);
        }
        
    }
    IEnumerator turnoff()
    {
        yield return new WaitForSeconds(1);
        noGold.SetActive(false);
    }
   

}
