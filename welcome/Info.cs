using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour {

    public Text conversation;
    private float delta = 2.0f, timer = 0.0f;
    private int index = 1;

    private string[] content = { "Hi there, here is a dilemma you might (or more likely, might not) encounter in your daily life.",
    "There are several people tied on the one end of the rail and, on the other end, a train is ready to go.",
    "The train is unstoppable because of some magical power and running on the rail leading to the most victims.",
    "Are you, with the power to change the direction of the train,",
    "going to change the destiny of the others in order to achieve the maximum welfare in the society or leave without doing anything because of the sense of guilty.",
    "As creators of the game are welfarists, we hope less people die in this dilemma and believe that sacrifices must be made for the common good.",
    "Sounds like a classic moral dilemma in philosophy? But wild things happen in our world.",
    "Press W, A, S, D to move around.",
    "Press E to pull the handle to change the direction of the rail.",
    "Do remember that train is dangerous but may be useful.",
    "Press space to make train run immediately."};

	// Use this for initialization
	void Start () {
        conversation.text = content[0];
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer >= delta) {
            index = (index + 1) % content.Length;
            conversation.text = content[index];
            timer -= delta;
        }
	}
}
