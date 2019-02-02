using UnityEngine;
using System.Collections;

public class gun : MonoBehaviour {

    int gunNumber;
    public GameObject gun1;
    public GameObject gun2;
    public GameObject gun3;
    public GameObject gun4;
	
	void Awake () {
        gunNumber = PlayerPrefs.GetInt("gunNumber");
        if (gunNumber == 0 || gunNumber == 1)
        {
            gun1.SetActive(true);
            gun2.SetActive(false);
            gun3.SetActive(false);
            gun4.SetActive(false);
        }
        if (gunNumber == 2)
        {
            gun1.SetActive(false);
            gun2.SetActive(true);
            gun3.SetActive(false);
            gun4.SetActive(false);
        }
        if (gunNumber == 3)
        {
            gun1.SetActive(false);
            gun2.SetActive(false);
            gun3.SetActive(true);
            gun4.SetActive(false);
        }
        if (gunNumber == 4)
        {
            gun1.SetActive(false);
            gun2.SetActive(false);
            gun3.SetActive(false);
            gun4.SetActive(true);
        }

    }
}
