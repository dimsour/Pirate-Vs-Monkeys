using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class mainMenu : MonoBehaviour {

    public void play()
        {
        SceneManager.LoadScene("inGame");
        }
    public void quit()
    {
        Application.Quit();
        Debug.Log("app quit");
    }
    public void back()
    {
        SceneManager.LoadScene("mainMenu");
    }
    public void highScoreButton()
    {
        SceneManager.LoadScene("highScores");
    }
    public void store()
    {
        SceneManager.LoadScene("store");
    }

}
