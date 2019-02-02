using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class onlineHighscores : MonoBehaviour {

    public string[] highscoresString;
    public int size;
    public Text highscoresTextUI;
    public GameObject internetCheck;
    public GameObject loading;
    public GameObject serverDown;
    public GameObject highscoresText1;
    public string tempString, tempString1, fullString;
    public Button setHighscore;


    public void Update()
    {
        if (fullString.Contains("MySQL server has gone away") || fullString.Contains("You don't have permission to access"))
        {
            serverDown.SetActive(true);
            highscoresText1.SetActive(false);
            setHighscore.interactable=false;
        }
        else
        {
            serverDown.SetActive(false);
            highscoresText1.SetActive(true);
            setHighscore.interactable = true;
        }
    }
    IEnumerator Start() {
        WWW highscores = new WWW("https://dimsour.000webhostapp.com/highscores.php");
        loading.SetActive(true);
        yield return highscores;
        loading.SetActive(false);
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            internetCheck.SetActive(true);
        }
        else
        {
            internetCheck.SetActive(false);
        }
        string highscoresText = highscores.text;
       // print(highscoresText);
        highscoresString = highscoresText.Split(';');
        size = highscoresString.Length;
        for(int i=0;i<20;i++)
        {
            tempString =(GetDataValue(highscoresString[i], "nickname:") );
            tempString1 = (GetDataValue(highscoresString[i], "score:") + "\n");
            highscoresTextUI.text += string.Format("{0,-13}",tempString);
            highscoresTextUI.text += string.Format("{0,13}", tempString1);
            fullString = highscoresTextUI.text;
        }
        
	}
	
	string GetDataValue (string data,string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if(value.Contains("|"))
        value = value.Remove(value.IndexOf("|"));
        return value;
	}
    
}
