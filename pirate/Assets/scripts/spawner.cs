using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {

    public GameObject enemy,blackEnemy;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public float startWait;
    public float spawnX;
    public bool stop,aristeroSpawn,aeras;
    public int randomBlack,Score,blackRate;
    public Score scoreScript;

   // int randEnemy;

    void Awake ()
    {
      startWait = Random.Range(1, 6);
    }
    void Start ()
    {
        StartCoroutine(waitSpawner());
        
    }
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
        Score = scoreScript.score;
        randomBlack = Random.Range(0,blackRate);
        if (aeras)
        {
            spawnX = Score * 0.001f;
        }
        else
            spawnX = 0;

        if(aristeroSpawn)
        {
            spawnX *= -1;
        }
    }

    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1,Random.Range (-spawnValues.z, spawnValues.z));
            if (randomBlack != 1)
                Instantiate((enemy), spawnPosition + transform.TransformPoint(spawnX, 0, 0), gameObject.transform.rotation);

            if(Score>=1000 && randomBlack==1)
            {
                Instantiate((blackEnemy), spawnPosition + transform.TransformPoint(spawnX, 0, 0), gameObject.transform.rotation);
            }

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
