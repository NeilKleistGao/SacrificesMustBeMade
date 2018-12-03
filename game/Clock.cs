using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {

    public GameObject trolly;
    public float timer = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timer > 0.0f){
            timer -= Time.deltaTime;
            if (!trolly.GetComponent<TrolleyMovement>().flag && Input.GetKeyUp(KeyCode.Space))
            {
                timer = 0.0f;
            }
        }
        else {
            trolly.GetComponent<TrolleyMovement>().flag = true;
            CameraSwitch camera = GetComponent<CameraSwitch>();
            camera.run();
        }
	}
}
