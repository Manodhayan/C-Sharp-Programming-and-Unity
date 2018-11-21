using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefab0;
    [SerializeField]
    GameObject prefab1;
    [SerializeField]
    GameObject prefab2;
    [SerializeField]
    GameObject prefab3;
    [SerializeField]
    GameObject prefab4;


    GameObject angryBird;

    int newBird = -1;
    //Position Support
    Vector3 position;
    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;
    void Start()
    {
        angryBird = Instantiate<GameObject>(prefab0, Vector3.zero, Quaternion.identity);
    }
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{

        if (Input.GetAxis("SpawnTeddyBear")>0)
        {
            
            if (!spawnInputOnPreviousFrame)
            {
                spawnInputOnPreviousFrame = true;
                position = Input.mousePosition;
                position.z = -Camera.main.transform.position.z;
                position = Camera.main.ScreenToWorldPoint(position);
                angryBird = Instantiate<GameObject>(prefab0, position, Quaternion.identity);
            }
        }
        else
        {
            spawnInputOnPreviousFrame = false;
        }

        // explode teddy bear as appropriate

        if (Input.GetAxis("DestroyBird") > 0 && GameObject.FindWithTag("TeddyBear")!=null)
        {
            if (!explodeInputOnPreviousFrame)
            {
                position = GameObject.FindWithTag("TeddyBear").transform.position;
                Destroy(GameObject.FindWithTag("TeddyBear"));
                explodeInputOnPreviousFrame = true;
                Instantiate<GameObject>(prefabExplosion, position, Quaternion.identity);

            }
        }
        else
        {
            explodeInputOnPreviousFrame = false;
        }

    }
}
