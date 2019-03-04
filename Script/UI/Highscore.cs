using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {
    int m_Score,highscore;
    
    public Text scoreDisplay;
    public Text HighScore;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //get score
        m_Score = PlayerPrefs.GetInt("Score", 0);
        //get highscore
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        //display score
        scoreDisplay.text = ("YourScore: ") + m_Score.ToString();
        //display highscore
        HighScore.text = ("HighScore: ") + highscore.ToString();
    }
}
