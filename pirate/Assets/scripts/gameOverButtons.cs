using UnityEngine;
using UnityEngine.Advertisements;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOverButtons : MonoBehaviour {

    int randomNum;
    public void Awake()
    {
        randomNum = Random.RandomRange(0, 3);
        print(randomNum);
    }

    public void quit()
    {
        if (randomNum == 1)
        {
            if (Advertisement.IsReady())
                Advertisement.Show();
            SceneManager.LoadScene("mainMenu");
            Time.timeScale = 1;
        }
        else
        {
            SceneManager.LoadScene("mainMenu");
            Time.timeScale = 1;
        }
    }

    public void retry()
    {
        if (randomNum == 1)
        {
            //Advertisement.Show();
            if (Advertisement.IsReady())
            {
                Advertisement.Show(new ShowOptions() { resultCallback = HandleAdResult });
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
            }
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
    }
    private void HandleAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Time.timeScale = 1;
                break;
            case ShowResult.Skipped:
                Time.timeScale = 1;
                break;
        }
    }


}
