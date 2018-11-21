using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleTeddyBear : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector3 newScale = transform.localScale;
        newScale.x *= 3;
        transform.localScale = newScale;
    }
	
	
}
