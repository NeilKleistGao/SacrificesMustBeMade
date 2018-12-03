using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMap : MonoBehaviour {

    private GameObject parent = null;
    public GameObject trolly;

	// Use this for initialization
	void Start () {
        for (int i = 1; i <= 7; i++) {
            if (i != StaticData.level) {
                GameObject game = GameObject.Find(i.ToString());
                Destroy(game);
            }
            else{
                parent = GameObject.Find(i.ToString());

                foreach (Transform child in parent.transform) {
                    if (child.gameObject.name.Contains("Target")) {
                        Node node = child.gameObject.GetComponent<Node>();
                        foreach (string item in node.list) {
                            StaticData.saved_list.Add(item);
                        }
                    }
                }
            }
        }

        GameObject pos = null;
        foreach (Transform child in parent.transform) {
            if (child.gameObject.name == "Start") {
                pos = child.gameObject;
                break;
            }
        }

        trolly.transform.position = new Vector3(pos.transform.position.x, pos.transform.position.y, 0);
        TrolleyMovement movement = trolly.GetComponent<TrolleyMovement>();
        movement.current = pos;
        movement.next = movement.current.GetComponent<Node>().next.gameObject;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
