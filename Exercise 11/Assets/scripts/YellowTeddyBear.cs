using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTeddyBear : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		//  quadruple  width  and  height
        Vector3 newScale = transform.localScale;
        newScale.x *= 4;
        newScale.y *= 4;
        transform.localScale = newScale;
    }
	
	
}
