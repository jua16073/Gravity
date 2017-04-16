using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravedad : MonoBehaviour {
    Rigidbody2D gravedad;
    Vector2 vel = new Vector2();
	// Use this for initialization
	void Start () {
        gravedad = GetComponent<Rigidbody2D>();
       /* vel.y = 9.8f;
        gravedad.velocity = vel;*/
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.Space))
        {
            gravedad.gravityScale = -gravedad.gravityScale;
            /*vel.y = -vel.y;
            gravedad.velocity = vel;*/
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name== "Piedra")
        {
            Destroy(this.gameObject);
        }
    }
}
