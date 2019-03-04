using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class Credit : MonoBehaviour
{
    public VideoPlayer vid;
    private double currentTime;
    private float volume;
    // Start is called before the first frame update
    void Start()
    {
        //play video
        vid.GetComponent<VideoPlayer>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        //get volume 
        volume = PlayerPrefs.GetFloat("SoundState");
        gameObject.GetComponent<AudioSource>().volume= volume;
        CheckOver();
        //while recieve anykey go to menu 
        if (Input.anyKeyDown)
        {
            BackMenu();
        }
    }

    private void CheckOver()
    {
        currentTime = vid.GetComponent<VideoPlayer>().time;
        if (currentTime >= 17.00)
        {
            BackMenu();
        }
    }
    private void BackMenu()
    {
        // go back to menu
        SceneManager.LoadScene("MainMenu");
    }
}
