using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piedras : MonoBehaviour {
    Rigidbody2D vel;
    Vector2 velo = new Vector2();
    System.Random rnd = new System.Random();
	// Use this for initialization
	void Start () {
        this.name = "Piedra";
        vel = GetComponent<Rigidbody2D>();
        velo.x = -rnd.Next(2, 10);
        velo.y = 0.0f;
        vel.velocity = velo;
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "LEFT") {
            Destroy(this.gameObject);
            } 
    }
}
