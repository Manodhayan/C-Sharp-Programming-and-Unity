using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour {

    //Timer support
    float TotalResizeSeconds = 2;
    float elapsedResizeSeconds = 0;
    //Resizing Control
    float ScaleFactorPerSecond = 1;
    int scaleFactorSignMultiplier = 1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // resize the game object
        Vector3 newScale = transform.localScale;
        newScale.x += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        newScale.y += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        transform.localScale = newScale;

        // update timer and check if it's done
        elapsedResizeSeconds += Time.deltaTime;
        if (elapsedResizeSeconds >= TotalResizeSeconds)
        {

            // reset timer and start resizing the game object
            // in the opposite direction
            elapsedResizeSeconds = 0;
            scaleFactorSignMultiplier *= -1;
        }
    }
}
