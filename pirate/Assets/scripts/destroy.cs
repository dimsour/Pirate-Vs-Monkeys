using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour
{

    public GameObject bullet;

    void Update()
    {
        bullet = GameObject.Find("Bullet(Clone)");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == bullet)
        {
            Destroy(this.gameObject);

        }
    }
}

    
    
