using UnityEngine;
using System.Collections;

public class sword : MonoBehaviour
{

    int swordNumber;
    public GameObject sword1;
    public GameObject sword2;
    public GameObject sword3;
    public GameObject sword4;

    void Awake()
    {
        swordNumber = PlayerPrefs.GetInt("swordNumber");
        if (swordNumber == 0 || swordNumber == 1)
        {
            sword1.SetActive(true);
            sword2.SetActive(false);
            sword3.SetActive(false);
            sword4.SetActive(false);
        }
        if (swordNumber == 2)
        {
            sword1.SetActive(false);
            sword2.SetActive(true);
            sword3.SetActive(false);
            sword4.SetActive(false);
        }
        if (swordNumber == 3)
        {
            sword1.SetActive(false);
            sword2.SetActive(false);
            sword3.SetActive(true);
            sword4.SetActive(false);
        }
        if (swordNumber == 4)
        {
            sword1.SetActive(false);
            sword2.SetActive(false);
            sword3.SetActive(false);
            sword4.SetActive(true);
        }

    }
}
