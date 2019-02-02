using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pause : MonoBehaviour {
    public bool gameIsPaused;
    public Button PauseButton;
    public GameObject gamePausedUI,adRequest ;
    public shipClick shipScript;
    public AudioSource musicSource;

    void Update()
    {
        if (adRequest.active)
        {
            PauseButton.interactable = false;
            shipScript.enabled = false;
        }
        else
        {
            PauseButton.interactable = true;
            shipScript.enabled = true;
        }
        if (gameIsPaused)
        {
            shipScript.enabled = false;
        }
        else
        {
            shipScript.enabled = true;
        }
    }
    public void pauseGame()
    {
        Time.timeScale = 0;
        gameIsPaused = true;
        gamePausedUI.SetActive(true);
        musicSource.Pause();

    }

    public void resumeGame()
    {
        Time.timeScale = 1;
        gameIsPaused = false;
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        gamePausedUI.SetActive(false);
        musicSource.UnPause();
    }

    }
