using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash : MonoBehaviour {

    TrolleyMovement trolley;
	// Use this for initialization
	void Start () {
        trolley = GetComponent<TrolleyMovement>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision){
        if (trolley.flag && collision.gameObject.name == "Player") {
            StaticData.suicide = true;
            StaticData.sacrificed_list.Add("Yourself");
        }
    }
}
