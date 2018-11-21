using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour
{
	/// <summary>
    /// Use this for initialization
    /// </summary>
	void Start()
    {
        // get the teddy bear moving
        GetComponent<Rigidbody2D>().AddForce(new Vector2(5, 0),ForceMode2D.Impulse);

    }
	
}