using UnityEngine;
using System.Collections;

public class timerScript : MonoBehaviour {

    public int timeNow;
    public int timeThen;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        timeNow = System.DateTime.Now.Hour;

	}
}
