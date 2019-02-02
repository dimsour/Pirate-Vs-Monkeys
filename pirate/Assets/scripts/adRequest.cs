using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;

public class adRequest : MonoBehaviour {

   public Health pirateHealth;
    public gameOverGM gameOverScript;
    public GameObject adRequestOff;



    public void yesButton()
    {
       if(Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo",new ShowOptions() { resultCallback = HandleAdResult });
        }
    }

    public void noButton()
    {
        gameOverScript.adPlayed = true;
        gameOverScript.endGame();
    }

    private void HandleAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                pirateHealth.health = 3;
                gameOverScript.adPlayed = true;
                adRequestOff.SetActive(false);
                break;
        }
    }
    
}
