using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintMessage : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Hi! Manodhayan!");
        int MaxScore=100;
        int score = 78;
        float percent = (float)score / MaxScore;
        print("Your Score: "+percent*100+"%");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
