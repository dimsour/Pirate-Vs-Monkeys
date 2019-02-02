using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class swordHit : MonoBehaviour
{
    public float fillAmount;
    public int swordCD;
    public float seconds,secCanHit;
    public bool bhke;
    public bool clicked;
    public bool patithike;
    public bool clicked1;
    public bool fortose;
    public bool canHit;

    public Vector3 mousePosition;
    public Button swordButton;
    public Button swordButton1;
    public Button swordButton2;
    public SwordButton SwordButtonScript;
    public Image loading;
    public GameObject sword;
    
    void Start()
    {
       
    }

    void Update()
    {
        secCanHit += Time.deltaTime;
        seconds += Time.deltaTime;
        fillAmount = seconds / swordCD;
        loading.fillAmount = fillAmount;
        clicked = SwordButtonScript.buttonClicked;
        sword = GameObject.Find("sword");
        swordCD = sword.GetComponent<swordStats>().swordCD;


        if (seconds>=swordCD)
        {
            bhke = true;
            swordButton.interactable = true;
            swordButton1.interactable = true;
            swordButton2.interactable = true;
            seconds = swordCD;
            loading.GetComponent<AudioSource>().enabled = true;
            patithike = false;
            fortose = true;
        }

        if (clicked)
        {
            seconds = 0;
            patithike = true;
            loading.GetComponent<AudioSource>().enabled = false;
            swordButton.interactable = false;
            swordButton1.interactable = false;
            swordButton2.interactable = false;
            fortose = false;
        }
        if(secCanHit>=0.008f) //test
        {
            secCanHit = 0.008f;
            canHit = true;
        }
    }
}
