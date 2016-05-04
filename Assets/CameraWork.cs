using UnityEngine;
using System.Collections;

public class CameraWork : MonoBehaviour {
    GameObject ball;
	// Use this for initialization
	void Start () {
        ball = GameObject.Find("Ball");
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        Debug.Log(coins[6].name);
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(0,
            ball.transform.position.y + 3,
            ball.transform.position.z - 14);
	}
}
