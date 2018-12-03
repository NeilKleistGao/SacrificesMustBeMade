using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

    public Camera main, remain;
	// Use this for initialization
	void Start () {
        main.enabled = true;
        remain.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void run() {
        main.enabled = false;
        remain.enabled = true;
    }
}
