using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject[] obstaclePatterns;
    private float timeToSpawn;
    public float startTimeToSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
   // bool isCreated;
    // Use this for initialization
    void Start () {
       // isCreated = false;

    }
	
	// Update is called once per frame
	void Update () {
        //find player
        GameObject player = GameObject.Find("Player");
        //if player not alive
        if (!player)
        {
            //pause
            Time.timeScale = 0;
        }
        //if player is alive
        else
        {
            //resume
            Time.timeScale = 1;
        }
        if (timeToSpawn <= 0)
        {
            //make a random for spawning
            int rand = Random.Range(0, obstaclePatterns.Length);
            //Debug.Log("random"+rand);
          
            //spawn object on obj
            GameObject obj = Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity) as GameObject;
            Destroy(obj,1);
            
            
            timeToSpawn = startTimeToSpawn;
            if(startTimeToSpawn> minTime)
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
