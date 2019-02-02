using UnityEngine;
using System.Collections;

public class gameOverGM : MonoBehaviour {
    public int health;
    public bool gameIsOver, firstGame, adPlayed = false;
    public int score;
    bool ended = false;

    public Score scoreScript;
    public Health pirateHealth;

    public GameObject gameOverUI;
    public GameObject spawnerOff;
    public GameObject pauseButton;
    public GameObject swordHitButton;
    public GameObject adRequest,ship,shipCd;
    

    void Start()
    {
        ZPlayerPrefs.Initialize("h@takeKak@sh114", "h@takeKak@sh1");
    }
    void Update () {

        health = pirateHealth.health;
        score = scoreScript.score;

       if (health <= 0 && !adPlayed)
        {
           adRequest.SetActive(true);
        }
        if (health <= 0 && adPlayed)
        {
            adRequest.SetActive(false);
            if (ended == false)
            {
                endGame();
                ended = true;
            }
        }
    }

    public void endGame()
    {
        adRequest.SetActive(false);
        gameOverUI.SetActive(true);
        spawnerOff.SetActive(false);
        pauseButton.SetActive(false);
        swordHitButton.SetActive(false);
        ship.SetActive(false);
        shipCd.SetActive(false);
        gameIsOver = true;

        if (ZPlayerPrefs.GetFloat("highscore") < score)
        {
            ZPlayerPrefs.SetFloat("highscore", score);
            ZPlayerPrefs.SetInt("posttest", 0);
        }
    }

    }

