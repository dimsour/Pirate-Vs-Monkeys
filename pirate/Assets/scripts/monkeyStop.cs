using UnityEngine;
using System.Collections;

public class monkeyStop : MonoBehaviour
{  
    
	void Update ()
    {
        if (GameObject.Find("pirate").GetComponent<Health>().health<=0)
        {
            Destroy(this.gameObject,0.1f);
            //Destroy(transform.parent.gameObject,0.1f);
        }
    }
}
