using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class armAngle : MonoBehaviour
{
    public float Angle=0,plusAngle =0,TimeT,angleLeft=0;
    public int flipTrue = 1;
    public bool facingRightArm,doShoot,clickedButton;
    public bool delay,didHit,didNotHit,click,leftClick,rightClick;
    public float attackSpeed;


    
    public flip flipScript;
    public Shoot ShootScript;
    public swordHit swordScript;
    public button1 button1Script;
    public GameObject flipScript1;
    

    public void  Update ()

    {
        leftClick = button1Script.leftClick;
        rightClick=button1Script.rightClick;
        TimeT += Time.deltaTime;
        if ( TimeT > attackSpeed+0.1f && Input.GetMouseButtonDown(0))
        {
            Ray toMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit rhInfo;
            didHit = Physics.Raycast(toMouse, out rhInfo);
            if (didHit)
            {
                clickedButton = true; 
                StartCoroutine(delay1()); 
            }
            if (!clickedButton)
            {
                test();
            }
            if (Angle >= 90 || Angle <= -90)
            {
                plusAngle = 180;
                angleLeft = -220;
            }
            else
            {
                angleLeft = 0;
                plusAngle = 0;
            }
        }
    }
    public void test()
    {
        doShoot = true;
        TimeT = 0;

        facingRightArm = flipScript.facingRight;
        Vector2 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        Angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, Angle + plusAngle);

        if (Angle >= 90 || Angle <= -90)
        {
            plusAngle = 180;
            angleLeft = -220;
        }
        else
        {
            angleLeft = 0;
            plusAngle = 0;
        }
        if (Angle >= -90.0 && Angle <= 90.0 && facingRightArm == false)
        {
            flipTrue = -1;
            ShootScript.doShoot();
        }
        else if ((Angle > 90.0 || Angle < -90.0) && facingRightArm == true)
        {
            flipTrue = -1;
            ShootScript.doShoot();
        }
        else
        {
            flipTrue = 1;
            ShootScript.doShoot();
        }
        transform.eulerAngles = new Vector3(0, 0, flipTrue * (Angle + plusAngle));
    
        StartCoroutine(efekt());
        
    }
    IEnumerator efekt()
    {

        yield return new WaitForSeconds(attackSpeed);
        transform.rotation = Quaternion.Euler(0f, 0f, -70f + angleLeft);
    }
    IEnumerator delay1()
    {
        yield return new WaitForSeconds(0.5f);
        clickedButton = false;
        didHit = false;
    }
}
