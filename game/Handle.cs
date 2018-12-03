using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle : MonoBehaviour {

    public Node child;
    public GameObject[] images = new GameObject[2];

    private GameObject target = null;
    public const string target_name = "Player";

    private int index = 0;

    // Use this for initialization
    void Start () {
        images[index].transform.position = new Vector3(images[index].transform.position.x, images[index].transform.position.y, 0);
        images[index ^ 1].transform.position = new Vector3(images[index ^ 1].transform.position.x, images[index ^ 1].transform.position.y, -999);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E) && target != null){
            images[index].transform.position = new Vector3(images[index].transform.position.x, images[index].transform.position.y, -999);
            images[index ^ 1].transform.position = new Vector3(images[index ^ 1].transform.position.x, images[index ^ 1].transform.position.y, 0);

            child.next = child.child[index ^ 1];

            index ^= 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == target_name)
        {
            target = collision.gameObject;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        target = null;
    }
}
