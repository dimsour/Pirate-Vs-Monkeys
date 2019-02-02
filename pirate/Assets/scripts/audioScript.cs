using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScript : MonoBehaviour {

    public AudioClip[] music;
    public int mute,random;
    public AudioSource musicSource;
    public GameObject Pause,GameOver,musicGO;

    void Awake ()
    {
        RandomMusic();
        mute = PlayerPrefs.GetInt("mute");
        if (mute == 1)
        {
            musicGO.SetActive(false);
        }

    }
	void Update()
    {
        
        if (!Pause.active)
        {
            if (!musicSource.isPlaying)
            {
                RandomMusic();
            }
        }
        if(GameOver.active)
        {
            musicSource.Stop();
        }

    }
	void RandomMusic ()
    {
        random = Random.Range(0,music.Length);
        musicSource.clip = music[random];
        musicSource.Play();
	}
}
