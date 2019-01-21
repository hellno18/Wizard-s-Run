using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GotoHighscore : MonoBehaviour {
    public GameObject gameover;
    public GameObject buttonHighscore;
    public AudioClip sfx;
    public AudioClip bgmFirst;
    public AudioClip bgmSecond;
    public AudioSource source;
    public GameObject leftButton;
    public GameObject rightButton;
    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        
        source.clip = bgmFirst;
        source.Play(); // play BGM sound
    }
	
	// Update is called once per frame
	void Update () {
        GameObject player = GameObject.Find("Player");
        
        if (player == null)
        {
            leftButton.SetActive(false);
            rightButton.SetActive(false);
            gameover.SetActive(true);
            buttonHighscore.SetActive(true);
        }
        if (player != null)
        {
            leftButton.SetActive(true);
            rightButton.SetActive(true);
            gameover.SetActive(false);
            buttonHighscore.SetActive(false);
        }
	}

    public void Highscore()
    {
        SceneManager.LoadScene("HighScore");
        source.PlayOneShot(sfx, 1f);
    }
   
}
