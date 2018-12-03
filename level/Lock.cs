using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour {

    public Button[] buttons = new Button[8];
	// Use this for initialization
	void Start () {
        for (int i = 1; i < buttons.Length; i++) {
            bool flag = (PlayerPrefs.GetInt(i.ToString(), 0) > 0);
            buttons[i].enabled = flag;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
