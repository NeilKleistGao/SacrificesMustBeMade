using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pull : MonoBehaviour {

    private GameObject target = null;
    public const string target_name = "";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && target != null) {
            //todo
        }
	}

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.name == target_name) {
            target = collision.gameObject;
        }
    }

    private void OnCollisionExit2D(Collision2D collision){
        target = null;
    }
}
