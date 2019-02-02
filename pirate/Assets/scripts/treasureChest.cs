using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class treasureChest : MonoBehaviour {


    public int gift1 , gift2 = 5000;
    public int randomNum;
    public GameObject treasureResultObj;
    public Text treasureResult;
    public Text CannonBuyText;
    public Button chestButton;
    public int timeYears;
    public int timeDays;
    public int timeHours;
    public int timeMinutes;
    public int timeSeconds;
    public int timeToMinutes;
    public int remainingTime;

    void Update()
    {
        timeDays = System.DateTime.Now.DayOfYear;
        timeYears = System.DateTime.Now.Year;
        timeHours = System.DateTime.Now.Hour;
        timeMinutes = System.DateTime.Now.Minute;
        timeSeconds = System.DateTime.Now.Second;


        timeToMinutes =(timeYears*525600) + (timeDays* 1440) +( timeHours * 60) +( timeMinutes ) ;
        remainingTime =( (PlayerPrefs.GetInt("timeToSeconds") - timeToMinutes));
        
        if (remainingTime >= 1)
        {
            CannonBuyText.text = "    " + remainingTime.ToString() + "\nMin. Left";
            chestButton.interactable = false;
        }
        else
        {
            CannonBuyText.text = "watch ad";
            chestButton.interactable = true;
        }
    }
    public void button()
    {
        if (Advertisement.IsReady())
        {
            Time.timeScale = 0;
            Advertisement.Show("rewardedVideo", new ShowOptions() { resultCallback = HandleAdResult });
        }
    }
	public void chest () {

        
        randomNum = Random.RandomRange(1,6);
        if(randomNum==1 || randomNum==2)
        {
            PlayerPrefs.SetInt("totalGold", (PlayerPrefs.GetInt("totalGold") + gift1));
            treasureResult.text=("5000 GOLD !!");
            treasureResultObj.SetActive(true);
            StartCoroutine(turnoff());

        }
        else if (randomNum==3)
        {
            PlayerPrefs.SetInt("totalGold", (PlayerPrefs.GetInt("totalGold") + gift2));
            treasureResult.text=("10000 GOLD !!");
            treasureResultObj.SetActive(true);
            StartCoroutine(turnoff());
        }
        else if(randomNum==4||randomNum==5)
        {
            if(PlayerPrefs.GetInt("numberOfBalls")<5)
            {
                PlayerPrefs.SetInt("numberOfBalls", 5);
                treasureResult.text=("MAX CANNONBALLS !!");
                treasureResultObj.SetActive(true);
                StartCoroutine(turnoff());
            }
            else
            {
                PlayerPrefs.SetInt("totalGold", (PlayerPrefs.GetInt("totalGold") + gift1));
                treasureResult.text=("5000 GOLD !!");
                treasureResultObj.SetActive(true);
                StartCoroutine(turnoff());
            }
        }

	}

    private void HandleAdResult(ShowResult result)
    {
        switch(result)
        {
            case ShowResult.Finished:
                chest();
               PlayerPrefs.SetInt("timeToSeconds", timeToMinutes+60);
                Time.timeScale = 1;
                break;
        }
    }

    IEnumerator turnoff()
    {
        yield return new WaitForSeconds(2);
        treasureResultObj.SetActive(false);
    }
}
