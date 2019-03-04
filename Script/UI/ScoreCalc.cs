using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCalc : MonoBehaviour {
    public int score;
    public static int highestScore;
    public Text scoreDisplay;
    public Text hpDisplay;
    public Image heart;
    public AudioClip sfxHit;
    public AudioClip sfxScore;
    public AudioSource source;
    Player player;
	// Use this for initialization
	void Start () {
        score = 0;
        heart.fillAmount = 1;
        player = GameObject.Find("Player").GetComponent<Player>();
        source = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
        scoreDisplay.text = ("Score: ")+score.ToString();
        hpDisplay.text = ("HP: ") + player.health.ToString();
        if (score > highestScore)
        {
            highestScore = score;
            //set highscore
            PlayerPrefs.SetInt("HighScore", highestScore);
        }
    }
    public void getScore(int a)
    {
        score += a;
        source.PlayOneShot(sfxScore, 0.5f);
        PlayerPrefs.SetInt("Score", score);
        if (score < 0)
        {
            score = 0;
            //set score
            PlayerPrefs.SetInt("Score", score);
        }
        //Debug.Log("scoret:" + score);
    }
}
