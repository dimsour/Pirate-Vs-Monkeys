using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class monkey : MonoBehaviour

{
    public int n, x = 400;
    public int randomHealth;
    public int maxHealth;
    public int tempHealth;
    public int score100;
    public int swordDamage;
    private int score,y=20;

    public float jump;
    public float groundCheckRadius;

    public bool grounded;
    public bool nikise=false;
    public bool onMonkey;
    public bool swordCol;
    public bool holyMonkey,blackMonkey;
    
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public GameObject bullet;
    public GameObject Score1;
    public GameObject Health;
    public GameObject sword;
    public GameObject winSound;

    public AudioSource audio;
    public AudioSource audioHolly;
    public void Awake()
    {
        randomHealth = Random.Range(0, y);
    }
    void Start()
    {
        if (blackMonkey)
            maxHealth = 3;
        else
            maxHealth = 2;

        tempHealth = maxHealth;
        bullet = GameObject.Find("Bullet(Clone)");
        Score1 = GameObject.Find("Score");
        Health = GameObject.Find("pirate");          
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "pirate")
        {
            
            nikise = true;
            Destroy(this.gameObject,0.3f);
            Destroy(transform.parent.gameObject,0.3f);
            winSound.SetActive(true);
        }
        if(col.gameObject.name == "Bullet(Clone)"||col.gameObject.name == "Bullet4(Clone)")
        { 
            audio.Play();
            tempHealth -= 1;
        }
        
        if (col.gameObject.name == "slash"|| col.gameObject.name == "saberSlash")
        {
            if (!swordCol) {
                swordCol = true;
                tempHealth -= swordDamage;
                audio.Play();
            }
        }
        if(col.gameObject.name == "explosion1" || col.gameObject.name == "explosion2" || col.gameObject.name == "explosion3" || col.gameObject.name == "explosion4")
        {
            tempHealth = 0;
        }
    }
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position , groundCheckRadius, whatIsGround);
    }

    void Update()
    {
        sword = GameObject.Find("sword");
        swordDamage = sword.GetComponent<swordStats>().swordDamage;
        if ((randomHealth == 1) && Score1.GetComponent<Score>().score > 50 && Health.GetComponent<Health>().health <=2 )
        {
            holyMonkey = true;
        }
        if (tempHealth <= 0)
        {
            if (grounded)
            {
                score = 10;
                if (holyMonkey)
                {
                    Health.GetComponent<Health>().health += 1;
                    audioHolly.Play();
                }
                }
            else if (!grounded && swordCol)
            {
                score = 10;
                if (holyMonkey)
                {
                    Health.GetComponent<Health>().health += 1;
                    audioHolly.Play();
                }
                }
            else
            {
                score = 20;
                if (holyMonkey)
                {
                    Health.GetComponent<Health>().health += 1;
                    audioHolly.Play();
                }
            }
            Destroy(this.gameObject);
            Destroy(transform.parent.gameObject, 0.3f);
        }
        Score1.GetComponent<Score>().score += score;
        Score1.GetComponent<Score>().scoreTemp += score;
        n = Random.Range(0, x);
        if ((n==10)&& grounded)
        {
           GetComponent<Rigidbody2D>().velocity = new Vector2
           (GetComponent<Rigidbody2D>().velocity.x, jump);
        }
    }
}
