using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharectorChanger : MonoBehaviour {
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


    //Create an angry bird
    GameObject angryBird;
    int newBird;

    // Use this for initialization
    void Start () {
        angryBird = Instantiate<GameObject>(prefab0, Vector3.zero, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 position = transform.position;
            Destroy(angryBird);
            newBird += 1;
            if (newBird == 0) { angryBird = Instantiate<GameObject>(prefab0, Vector3.zero, Quaternion.identity); }
            else if (newBird == 1) { angryBird = Instantiate<GameObject>(prefab1, Vector3.zero, Quaternion.identity); }
            else if (newBird == 2) { angryBird = Instantiate<GameObject>(prefab2, Vector3.zero, Quaternion.identity); }
            else if (newBird == 3) { angryBird = Instantiate<GameObject>(prefab3, Vector3.zero, Quaternion.identity); }
            else { angryBird = Instantiate<GameObject>(prefab4, Vector3.zero, Quaternion.identity); newBird = -1; }
        }
    }
}
