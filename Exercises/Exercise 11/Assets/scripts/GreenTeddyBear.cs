using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTeddyBear : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector3 newScale = transform.localScale;
        newScale.y *= 3;
        transform.localScale = newScale;

    }
	

}
