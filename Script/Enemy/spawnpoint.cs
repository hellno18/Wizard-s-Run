using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpoint : MonoBehaviour {
    public GameObject obstacle;
    private float timeToSpawn;
    public float startTimeToSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    // Use this for initialization
    void Start () {
        timeToSpawn = startTimeToSpawn;
    }
	
	// Update is called once per frame
	void Update () {
        if (timeToSpawn <= 0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            timeToSpawn = startTimeToSpawn;
            if (startTimeToSpawn > minTime)
            {
                startTimeToSpawn -= decreaseTime;
            }
        }
        else
        {
            timeToSpawn -= Time.deltaTime;
        }
    }
}
