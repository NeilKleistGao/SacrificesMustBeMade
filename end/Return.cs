using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Return : MonoBehaviour {

    public Button again_button, next_button, return_button;

	// Use this for initialization
	void Start () {
        again_button.onClick.AddListener(playAgain);
        next_button.onClick.AddListener(next);
        return_button.onClick.AddListener(returnMain);

        if (StaticData.level == 7) {
            next_button.transform.position = new Vector3(-999, -999, -999);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void playAgain() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("game");
    }

    void next() {
        StaticData.level++;
        UnityEngine.SceneManagement.SceneManager.LoadScene("game");
    }

    void returnMain() {
        StaticData.level = 0;
        UnityEngine.SceneManagement.SceneManager.LoadScene("welcome");
    }
}
