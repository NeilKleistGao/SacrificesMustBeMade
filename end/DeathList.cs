using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathList : MonoBehaviour {

    public Text sacrificed_list, saved_list;
    public Text title;
    public Button next_button;
    // Use this for initialization
    void Start () {
        sacrificed_list.text = "";
        foreach (string item in StaticData.sacrificed_list) {
            if (StaticData.level == 7 && item == "Yourself") {
                sacrificed_list.text += "A Hero";
            }
            else {
                sacrificed_list.text += item;
            }

            sacrificed_list.text += "\n";
        }

        saved_list.text = "";
        foreach (string item in StaticData.saved_list){
            saved_list.text += item;
            saved_list.text += "\n";
        }

        if (StaticData.res <= StaticData.min[StaticData.level - 1]){
            if (StaticData.level == 7){
                if (StaticData.suicide){
                    title.text = "You Win";
                    PlayerPrefs.SetInt(StaticData.level.ToString(), 1);
                }
                else {
                    title.text = "You Lose";
                    next_button.enabled = false;
                    next_button.transform.position = new Vector3(-999, -999, -999);
                }
            }
            else {
                title.text = "You Win";
                PlayerPrefs.SetInt(StaticData.level.ToString(), 1);
            }
        }
        else {
            title.text = "You Lose";
            next_button.enabled = false;
            next_button.transform.position = new Vector3(-999, -999, -999);
        }

        StaticData.sacrificed_list.Clear();
        StaticData.saved_list.Clear();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
