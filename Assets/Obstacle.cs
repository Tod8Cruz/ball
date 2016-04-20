using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
    float delta = -0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float newXPosition = transform.localPosition.x + delta;
        transform.localPosition = new Vector3(newXPosition,
            transform.localPosition.y,
            transform.localPosition.z);
        if (transform.localPosition.x < -3.5)
        {
            delta = 0.1f;
        }
        else if(transform.localPosition.x>3.5)
        {
            delta = -0.1f;
        }
	}
}
