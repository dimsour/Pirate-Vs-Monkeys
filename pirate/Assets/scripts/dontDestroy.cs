using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dontDestroy : MonoBehaviour {

   public AudioSource mainAudio;
    int mute;

    void Awake ()
    {
        
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if(objs.Length>1)
        {
            Destroy(this.gameObject);
        }
        
        DontDestroyOnLoad(this.gameObject);

       
	}
    void Update()
    {

        mute = PlayerPrefs.GetInt("mute");
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "inGame")
        {
            Destroy(this.gameObject);
        }

        if (mute == 0)
        {
            mainAudio.UnPause();
        }
        else
        {

            mainAudio.Pause();
        }
    }
}
	

