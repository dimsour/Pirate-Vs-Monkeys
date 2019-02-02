using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class button1 : MonoBehaviour
{
    public bool clickedRL,click,leftClick,rightClick;
    public flip flipScript;
    //public armAngle armAngleScript;
    public GameObject armScript;


    public void  Update()
    {
        armScript = GameObject.Find("gun");
    }
   public void TaskOnClick()
    {
        clickedRL = true;  
    }
    public void flipLeft()
     {
         if (flipScript.facingRight)
         {
            armScript.GetComponent<armAngle>().Angle = 150;
            armScript.GetComponent<armAngle>().plusAngle = 180;
            //armAngleScript.Angle = 150;
            //armAngleScript.plusAngle = 180;
        }
     }
     public void flipRight()
     {
        if(!flipScript.facingRight)
        {
            armScript.GetComponent<armAngle>().Angle = 15;
            armScript.GetComponent<armAngle>().plusAngle = 0;
            //armAngleScript.Angle = 15;
            //armAngleScript.plusAngle = 0;
        }
    }
    IEnumerator clicked()
    {
        yield return new WaitForSeconds(2f);
        clickedRL = false;
    }
}
