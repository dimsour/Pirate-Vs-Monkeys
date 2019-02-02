using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Shoot : MonoBehaviour
{
    public Quaternion gama;
    public armAngle armScript;
    public Transform firePoint;
    public Transform BulletTrailPrefab;
    public button1 button1Script;
    public bool clicked;
    void Awake()
    {
        firePoint = transform.FindChild("FirePoint");
        clicked = armScript.clickedButton;
    }

    public void doShoot()
    {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            gama = Quaternion.Euler(0f, 0f, armScript.Angle);
            Instantiate(BulletTrailPrefab, firePoint.position, gama);
           
    }
}



