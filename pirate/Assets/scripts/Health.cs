using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

    public int health = 3;
    public bool healthTest = false;
    public bool deksia=false;
    public bool animDone;

    public Vector3 scale;

	void Update ()
    {
        scale = transform.localScale;
        healthTest = false;
        if (!animDone)
        {
            if (health == 0)
            {
                if (scale.x >= 0)
                {
                    Animator anim = GetComponent<Animator>();
                    anim.Play("pirate_death");
                    animDone = true;
                }
                else
                {
                    Animator anim = GetComponent<Animator>();
                    anim.Play("pirate_death1");
                    animDone = true;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "monkey" && healthTest == false)
        {
            healthTest = true;
            health = health - 1;
        }
    }
}
