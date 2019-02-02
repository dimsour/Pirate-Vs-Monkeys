using UnityEngine;
using System.Collections;

public class spawnerSwitch : MonoBehaviour {

    public GameObject spawner;
	// Use this for initialization
	public void on () {
        if (!spawner.activeInHierarchy)
        {
            spawner.SetActive(true);
        }
        else
            spawner.SetActive(false);
	}
	

	
}
