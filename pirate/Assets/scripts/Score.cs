using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public int score, scoreTemp,startingPoints;
    public float monkeySpeed,extraMonkeySpeed;
    public bool started = false;
    public Text scoreText = null;
    public spawner spawnerScript1,spawnerScirpt2, spawnerScirpt3, spawnerScirpt4;
    public GameObject gun,sword;



    void Awake()
    {
        gun = GameObject.Find("gun");
        sword = GameObject.Find("sword");
        startingPoints += gun.GetComponent<gunStats>().startingPoints;
        startingPoints += sword.GetComponent<swordStats>().startingPoints;
        extraMonkeySpeed = (startingPoints / 50 * 0.1f);
        score += startingPoints;
        monkeySpeed += extraMonkeySpeed;
    }
    void Start()
    {
        
        spawnerScript1.spawnMostWait -= startingPoints* 0.0015f;
        spawnerScirpt2.spawnMostWait -= startingPoints * 0.0015f;
        spawnerScirpt3.spawnMostWait -= startingPoints * 0.0015f;
        spawnerScirpt4.spawnMostWait -= startingPoints * 0.0015f;

    }
	void Update () {
        //Debug.Log("spawner is" + (float)spawnerScript1.spawnMostWait);
        scoreText.text = score.ToString();
        if (scoreTemp == 50 || scoreTemp == 60)
        {
            scoreTemp = 0;
            if(score<=2200)
            {
                monkeySpeed += 0.1f;
                print(monkeySpeed);
            }
            
            if (score >= 1200)
            {
                if(score==1500||score==1510)
                {
                    spawnerScript1.blackRate -= 1;
                    spawnerScirpt2.blackRate -= 1;
                    spawnerScirpt3.blackRate -= 1;
                    spawnerScirpt4.blackRate -= 1;
                }
                if (score == 1700 || score == 1710)
                {
                    spawnerScript1.blackRate -= 1;
                    spawnerScirpt2.blackRate -= 1;
                    spawnerScirpt3.blackRate -= 1;
                    spawnerScirpt4.blackRate -= 1;
                }
                if (score == 1900 || score == 1910)
                {
                    spawnerScript1.blackRate -= 1;
                    spawnerScirpt2.blackRate -= 1;
                    spawnerScirpt3.blackRate -= 1;
                    spawnerScirpt4.blackRate -= 1;
                }

                
            }
            if (spawnerScirpt2.spawnMostWait > spawnerScirpt2.spawnLeastWait)
            {
                if (score <= 1400)
                {
                    spawnerScript1.spawnMostWait -= 0.075f;
                    spawnerScirpt2.spawnMostWait -= 0.075f;
                    spawnerScirpt3.spawnMostWait -= 0.075f;
                    spawnerScirpt4.spawnMostWait -= 0.075f;
                }
                else
                {
                    spawnerScript1.spawnMostWait -= 0.1f;
                    spawnerScirpt2.spawnMostWait -= 0.1f;
                    spawnerScirpt3.spawnMostWait -= 0.1f;
                    spawnerScirpt4.spawnMostWait -= 0.1f;
                }
            } 
        }
	}
}
