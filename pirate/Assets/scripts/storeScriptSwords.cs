using UnityEngine;
using System.Collections;

public class storeScriptSwords : MonoBehaviour
{

    public int swordNumber, gold;
    public int price2, price3, price4;
    public swordBuy swordBuyScript2, swordBuyScript3, swordBuyScript4;
    public bool sword2bought, sword3bought, sword4bought;
    public GameObject noGold;

    void Start()
    {
        price2 = swordBuyScript2.price;
        price3 = swordBuyScript3.price;
        price4 = swordBuyScript4.price;
    }
    void Update()
    {
       gold = PlayerPrefs.GetInt("totalGold");
    }
    public void sword1()
    {
        swordNumber = 1;
        PlayerPrefs.SetInt("swordNumber", swordNumber);
    }
    public void sword2()
    {
        if (!swordBuyScript2.bought)
        {
            if (gold >= swordBuyScript2.price)
            {
                PlayerPrefs.SetInt("totalGold", gold - price2);
                swordBuyScript2.bought = true;
                PlayerPrefs.SetInt("sword2", 1);
                print("boughttt");
            }
            else if (gold < swordBuyScript2.price)
            {
                noGold.SetActive(true);
                StartCoroutine(turnoff());
            }
        }
        if (swordBuyScript2.bought)
        {
            swordNumber = 2;
            PlayerPrefs.SetInt("swordNumber", swordNumber);
            print("equipted");
        }
    }
    public void sword3()
    {
        if (!swordBuyScript3.bought)
        {
            if (gold >= swordBuyScript3.price)
            {
                PlayerPrefs.SetInt("totalGold", gold - price3);
                swordBuyScript3.bought = true;
                PlayerPrefs.SetInt("sword3", 1);
            }
            else if (gold < swordBuyScript3.price)
            {
                noGold.SetActive(true);
                StartCoroutine(turnoff());
            }
        }
        if (swordBuyScript3.bought)
        {
            swordNumber = 3;
            PlayerPrefs.SetInt("swordNumber", swordNumber);
        }
    }
    public void sword4()
    {
        if (!swordBuyScript4.bought)
        {
            if (gold >= swordBuyScript4.price)
            {
                PlayerPrefs.SetInt("totalGold", gold - price4);
                swordBuyScript4.bought = true;
                PlayerPrefs.SetInt("sword4", 1);
            }
            else if (gold < swordBuyScript4.price)
            {
                
                noGold.SetActive(true);
                StartCoroutine(turnoff());
                print("not enough gold");
            }
        }
        if (swordBuyScript4.bought)
        {
            swordNumber = 4;
            PlayerPrefs.SetInt("swordNumber", swordNumber);
        }

    }
    IEnumerator turnoff()
    {
        yield return new WaitForSeconds(1);
        noGold.SetActive(false);
    }


}
