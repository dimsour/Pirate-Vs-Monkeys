using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class setHighscore : MonoBehaviour {

    string CreateUserURL = "https://dimsour.000webhostapp.com/setHighscore.php";
    public Text inputText;
    public GameObject postPostedText;
    public GameObject enternickname;
    string nickname;
    float score;
    int postTest;
    bool isNotEmpty;

    void Start()
    {
        ZPlayerPrefs.Initialize("h@takeKak@sh114", "h@takeKak@sh1");
    }
	public void setButton ()
    {
        nickname = inputText.text;
        score =ZPlayerPrefs.GetFloat("highscore");
        postTest = ZPlayerPrefs.GetInt("posttest");
        for(int i=0;i<nickname.Length;i++)
        {
            if (nickname[i]!=' ')
            {
                isNotEmpty = true;
                break;
            }
        }
        if (postTest == 0)
        {
            if (!isNotEmpty)
            {
                enternickname.SetActive(true);
                StartCoroutine(turnoff());
            }
            else
            {
                SetHighscore(nickname, score);
                postPostedText.SetActive(false);
                ZPlayerPrefs.SetInt("posttest", 1);

            }
        }
        else if (postTest == 1)
        {
            postPostedText.SetActive(true);
            StartCoroutine(turnoff());
        }
        
	}

    public void SetHighscore(string nickname,float score)
    {
        WWWForm form = new WWWForm();
        form.AddField("nicknamePost", nickname);
        form.AddField("scorePost",score.ToString());
        WWW www = new WWW(CreateUserURL, form);
        print("egine");
        StartCoroutine(reload());

    }

    IEnumerator turnoff()
    {
        yield return new WaitForSeconds(1);
        postPostedText.SetActive(false);
        enternickname.SetActive(false);
    }
    IEnumerator reload()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("highScores");
    }
}
