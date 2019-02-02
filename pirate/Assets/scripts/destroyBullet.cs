using UnityEngine;
using System.Collections;

public class destroyBullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "monkey")
        {
            Destroy(this.gameObject);
        }
    }
}
