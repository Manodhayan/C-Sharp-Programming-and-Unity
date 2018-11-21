using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour {

   
    // Use this for initialization
    void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);
            transform.position = position;

        
    }
}
