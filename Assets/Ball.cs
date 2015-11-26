using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    float startingPoint;
	// Use this for initialization
	void Start () {
        startingPoint = transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
        float distance;
        distance = transform.position.z - startingPoint;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*300);
        }
        
	}
}
