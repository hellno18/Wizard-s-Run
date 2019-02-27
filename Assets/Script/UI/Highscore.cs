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
        m_Score = PlayerPrefs.GetInt("Score", 0);
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        scoreDisplay.text = ("YourScore: ") + m_Score.ToString();
        HighScore.text = ("HighScore: ") + highscore.ToString();
    }
}
