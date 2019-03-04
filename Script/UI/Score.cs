using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    ScoreCalc scorecalc;
	// Use this for initialization
	void Start () {
        scorecalc = GameObject.Find("GameManager").GetComponent<ScoreCalc>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("obstacle"))
        {
            //get 2 point
            scorecalc.getScore(2);
        }
    }
}
