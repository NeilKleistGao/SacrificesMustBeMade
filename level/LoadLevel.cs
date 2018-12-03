using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour {

    public Button[] buttons = new Button[7];
	// Use this for initialization
	void Start () {
        buttons[0].onClick.AddListener(delegate () { click(1); });
        buttons[1].onClick.AddListener(delegate () { click(2); });
        buttons[2].onClick.AddListener(delegate () { click(3); });
        buttons[3].onClick.AddListener(delegate () { click(4); });
        buttons[4].onClick.AddListener(delegate () { click(5); });
        buttons[5].onClick.AddListener(delegate () { click(6); });
        buttons[6].onClick.AddListener(delegate () { click(7); });
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void click(int index) {
        StaticData.level = index;
        UnityEngine.SceneManagement.SceneManager.LoadScene("game");
    }
}
