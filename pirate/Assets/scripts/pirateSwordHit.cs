using UnityEngine;
using System.Collections;

public class pirateSwordHit : MonoBehaviour {

    public SwordButton SwordButtonScript;
    public button1 button1Script;
    public bool clicked;
    public bool delayed;
	
	void Update ()
    {
        clicked = SwordButtonScript.buttonClicked;
        if (clicked)
        {
            if (PlayerPrefs.GetInt("swordNumber") == 4)
            {
                
                Animator anim = GetComponent<Animator>();
                anim.Play("swordHitLightSaber");
            }
            else
            {
                Animator anim = GetComponent<Animator>();
                anim.Play("pirate_swordHit");
                //GetComponent<AudioSource>().enabled = true;
                StartCoroutine(delay());
            }
        }
    }


    IEnumerator delay()
    {
        yield return new WaitForSeconds(2f);
        GetComponent<AudioSource>().enabled = false;
    }
}
