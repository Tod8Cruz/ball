using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    void RestartGame()
    {
        Application.LoadLevel("Game");
    }

    void RedCoinStart()
    {
        DestroyObstacles();
    }

    void DestroyObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for (int i = 0; i < obstacles.Length; i++)
        {
            Destroy(obstacles[i]);
        }
    }


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
