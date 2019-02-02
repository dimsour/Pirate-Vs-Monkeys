using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SwordButton : MonoBehaviour
{

    public bool buttonClicked ;
    public bool patithike;

    public swordHit swordHitScript;
    public Transform pirate;
    public GameObject pirateScript;
    public Button Button1;
    public Button Button2;



    void Start()
    {
        Button btn = Button1.GetComponent<Button>();
        btn.onClick.AddListener(swordButton);

        Button btn1 = Button2.GetComponent<Button>();
        btn1.onClick.AddListener(swordButton);
    }
    void Update()
    {
        patithike = swordHitScript.patithike;
        if(patithike)
        {
            buttonClicked = false;
        }

    }

    public void swordButton()
    {
        buttonClicked = true;
        swordHitScript.canHit = false;
        swordHitScript.secCanHit = 0f;

    }
    public void stopArm()
    {
        pirateScript.GetComponent<armAngle>().enabled = false;
    }
}