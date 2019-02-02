using UnityEngine;
using System.Collections;

public class monkeyFollow : MonoBehaviour
{
    float speed;
    public bool challenged = true;
    public int scoreTemp;
    private bool gameIsPaused=false;


    private Vector3 directionOfCharacter;
    public GameObject Character;
    public GameObject PauseButton;
    public GameObject Score1;

    public void Start()
    {
       
        PauseButton = GameObject.Find("PauseButton");
        Character = GameObject.Find("pirate");
        Score1 = GameObject.Find("Score");
    }

    public void FixedUpdate()
    {
        speed = Score1.GetComponent<Score>().monkeySpeed;

        PauseButton.GetComponent<pause>().gameIsPaused = gameIsPaused;
        if (!gameIsPaused)
        {
            if (challenged)
            {
                directionOfCharacter = Character.transform.position *Time.timeScale - transform.position*Time.timeScale;
                directionOfCharacter = directionOfCharacter.normalized;
                transform.Translate(directionOfCharacter*speed/100,Space.World);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "pirate")
        {
            challenged = false;
        }
    }
}
