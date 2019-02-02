using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoScript : MonoBehaviour {

    public GameObject info;
    
	
	public void infoButton ()
    {
        info.SetActive(true);	
	}
    public void exitButton()
    {
        Animator anim = info.GetComponent<Animator>();
        anim.Play("infoanimexit");
        StartCoroutine(exit());
    }

    IEnumerator exit()
    {
        yield return new WaitForSeconds(1f);
        info.SetActive(false);
    }
}
