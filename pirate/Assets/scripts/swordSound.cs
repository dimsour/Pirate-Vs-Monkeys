using UnityEngine;
using System.Collections;

public class swordSound : MonoBehaviour {

    public swordHit swordhitScript;
    public bool clicked;

	void Update () {
        clicked = swordhitScript.clicked;
        if(clicked)
        {
            GetComponent<AudioSource>().enabled = true;
            StartCoroutine(delay());
        }
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(1f);
        GetComponent<AudioSource>().enabled = false;
    }
}
