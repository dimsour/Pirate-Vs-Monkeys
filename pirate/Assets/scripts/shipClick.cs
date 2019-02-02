using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shipClick : MonoBehaviour
{

    public bool shipClicked;
    public int numberOfBalls;
    public float timer,timer1;
    public GameObject cannonballs;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 5)
            timer = 5;
        timer1 += Time.deltaTime;
        if (timer1 >= 5.1f)
            timer1 = 5.1f;
        numberOfBalls = PlayerPrefs.GetInt("numberOfBalls");
            

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        RaycastHit hitInfo = new RaycastHit();
        // Casts the ray and get the first game object hit
        Physics.Raycast(ray, out hit);
        bool hitt = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
        if (numberOfBalls > 0)
        {
            if (timer1 == 5.1f)
            {
                if (hitt)
                {
                    if (hitInfo.transform.gameObject.name == "ship")
                    {
                        Debug.Log("fire!!");
                        cannonballs.SetActive(true);
                        shipClicked = true;
                        PlayerPrefs.SetInt("numberOfBalls", (numberOfBalls - 1));
                        timer = 0;
                        timer1 = 0;
                        StartCoroutine(turnOff());

                    }
                }
            }
        }

    }
    IEnumerator turnOff()
    {
        yield return new WaitForSeconds(5);
        shipClicked = false;
        cannonballs.SetActive(false);
    }

}
