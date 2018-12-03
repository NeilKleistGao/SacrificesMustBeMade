using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 0.0f;
    private Rigidbody2D body2d;

	// Use this for initialization
	void Start () {
        body2d = GetComponent<Rigidbody2D>();
        body2d.freezeRotation = true;
        body2d.gravityScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
        body2d.velocity = Vector2.zero;

        if (Input.GetKey(KeyCode.W)){
            body2d.AddForce(new Vector2(0, speed));
        }
        else if (Input.GetKey(KeyCode.S)){
            body2d.AddForce(new Vector2(0, -speed));
        }
        else if (Input.GetKey(KeyCode.A)){
            body2d.AddForce(new Vector2(-speed, 0));
        }
        else if (Input.GetKey(KeyCode.D)) {
            body2d.AddForce(new Vector2(speed, 0));
        }
	}

}
