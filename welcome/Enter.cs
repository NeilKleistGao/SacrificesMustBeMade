using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.name == "start"){
            UnityEngine.SceneManagement.SceneManager.LoadScene("level");
        }
        else if (collision.gameObject.name == "exit") {
            Application.Quit();
        }
    }
}
