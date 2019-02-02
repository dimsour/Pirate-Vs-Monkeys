using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cannonBuy : MonoBehaviour
{

    public GameObject notEnoughGold;
    public GameObject maxBalls;
    public Text CannonText;
    public int balls,gold,price;

    void start()
    {
        //price = 1000;
    }

	void Update () {
        balls = PlayerPrefs.GetInt("numberOfBalls");
        gold = PlayerPrefs.GetInt("totalGold");
        CannonText.text = (" Cannonballs : " + (PlayerPrefs.GetInt("numberOfBalls")));
    }

    public void cannonBuyVoid()
    {
        if (gold >= price)
        {
            if (balls < 5 && gold >= price)
            {
                PlayerPrefs.SetInt("numberOfBalls", (PlayerPrefs.GetInt("numberOfBalls") + 1));
                PlayerPrefs.SetInt("totalGold", (PlayerPrefs.GetInt("totalGold") - (price)));
            }
            else if (balls == 5)
            {
                maxBalls.SetActive(true);
                StartCoroutine(turnoff());
            }
        }
        else
        {
            notEnoughGold.SetActive(true);
            StartCoroutine(turnoff());
        }
    }
    IEnumerator turnoff()
    {
        yield return new WaitForSeconds(1);
        notEnoughGold.SetActive(false);
        maxBalls.SetActive(false);
    }
}
