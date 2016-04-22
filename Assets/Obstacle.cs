using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    void TestMethod(string name,int a)
    {
        float distance = Vector3.Distance(GameObject.Find(name).transform.position,
            transform.position);
        Debug.Log(name+"까지 거리: "+distance);
    }

    float delta = -0.1f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        TestMethod("Ground",0);
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
