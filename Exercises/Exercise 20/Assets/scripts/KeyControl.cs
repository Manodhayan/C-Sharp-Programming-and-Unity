using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class KeyControl : MonoBehaviour {

    // saved for efficiency
    float colliderHalfWidth;
    float colliderHalfHeight;

    


    float MoveUnitsPerSecond = 5;
    // Use this for initialization
    void Start () {
        // save for efficiency
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        colliderHalfWidth = collider.size.x / 2;
        colliderHalfHeight = collider.size.y / 2;

    }
	
	// Update is called once per frame
	void Update () {
        //Get Current position
        Vector3 position = transform.position;
        //Get keyboard Input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(horizontal!=0)
        {
            position.x += horizontal * MoveUnitsPerSecond * Time.deltaTime;
        }
        if (vertical != 0)
        {
            position.y += vertical * MoveUnitsPerSecond * Time.deltaTime;
        }
        transform.position = position;
        ClampInScreen();


    }

    void ClampInScreen()
    {
        // clamp position as necessary
        Vector3 position = transform.position;
        if (position.x - colliderHalfWidth < ScreenUtils.ScreenLeft)
        {
            position.x = ScreenUtils.ScreenLeft + colliderHalfWidth;
        }
        else if (position.x + colliderHalfWidth > ScreenUtils.ScreenRight)
        {
            position.x = ScreenUtils.ScreenRight - colliderHalfWidth;
        }
        if (position.y + colliderHalfHeight > ScreenUtils.ScreenTop)
        {
            position.y = ScreenUtils.ScreenTop - colliderHalfHeight;
        }
        else if (position.y - colliderHalfHeight < ScreenUtils.ScreenBottom)
        {
            position.y = ScreenUtils.ScreenBottom + colliderHalfHeight;
        }
        transform.position = position;
    }
}
