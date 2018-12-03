using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrolleyMovement : MonoBehaviour {

    public GameObject current, next;
    public bool flag = false;

    private Dictionary<Vector3, bool> visit = new Dictionary<Vector3, bool>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (flag) {
            if (transform.position != next.transform.position){
                transform.position = Vector3.MoveTowards(transform.position, next.transform.position, 0.05f);
            }
            else {

                if (visit.ContainsKey(transform.position)) {
                    end();
                }

                visit.Add(transform.position, true);

                int res = current.GetComponent<Node>().count;
                if (res > 0) {
                    Text txt = GameObject.Find("Score").GetComponent<Text>();
                    int temp = int.Parse(txt.text.Substring(11));
                    txt.text = "Sacrificed:" + (temp + res).ToString();

                    List<string> list = current.GetComponent<Node>().list;
                    foreach (string str in list) {
                        StaticData.sacrificed_list.Add(str);
                        StaticData.saved_list.Remove(str);
                    }
                }

                current = next;
                Node node = next.GetComponent<Node>();

                if (node.next != null){
                    next = node.next.gameObject;
                }
                else {
                    end();
                }
            }
        }
	}

    private void end(){
        Text txt = GameObject.Find("Score").GetComponent<Text>();
        StaticData.res = int.Parse(txt.text.Substring(11));
        StaticData.res = (StaticData.suicide) ? StaticData.res + 1 : StaticData.res;
        UnityEngine.SceneManagement.SceneManager.LoadScene("end");
    }
}

