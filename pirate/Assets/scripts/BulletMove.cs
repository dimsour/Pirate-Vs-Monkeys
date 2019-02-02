using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

    public int speed=5;
	void Update ()
    {
        Destroy(this.gameObject, 1f);
        transform.Translate(Vector3.right * Time.deltaTime * speed);
	}
}
