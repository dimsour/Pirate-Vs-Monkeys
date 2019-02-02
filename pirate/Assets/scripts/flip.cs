using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;


public class flip : MonoBehaviour {

    public bool facingRight = true;
    public bool clickedButton,clickedLeft,clickedRight;
    public float rotationAngle;

    //public armAngle armScript;
    public GameObject armScript;
    void Update()
    {
        {
            armScript = GameObject.Find("gun");
            rotationAngle = armScript.GetComponent<armAngle>().Angle;
            if (rotationAngle >= -90.0 && rotationAngle <= 90.0 && facingRight == false)
            {
                flip1();
                facingRight = true;
            }
            if ((rotationAngle > 90.0 || rotationAngle < -90.0) && facingRight == true)
            {
                flip1();
                facingRight = false;
            }
        }
    }
    public void flip1()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
