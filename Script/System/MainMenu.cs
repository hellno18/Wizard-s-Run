﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {
    public AudioClip sfx;
    private AudioSource source;
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    private void Update()
    {
        GameObject GameManager = GameObject.Find("GameManager");
        AudioSource audiosource = GameManager.GetComponent<AudioSource>();
        //set volume BGM
        audiosource.volume = PlayerPrefs.GetFloat("SoundState");
        //set volume SE
        source.volume = PlayerPrefs.GetFloat("SoundState");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
        source.PlayOneShot(sfx, 1.0f);
    }
    public void QuitGame()
    {
        Debug.Log("quit!");
        source.PlayOneShot(sfx, 1.0f);
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
        source.PlayOneShot(sfx, 1.0f);
    }
    public void Credit()
    {
        SceneManager.LoadScene("Credit");
        source.PlayOneShot(sfx, 1.0f);
    }
    public void Option()
    {
        SceneManager.LoadScene("Option");
        source.PlayOneShot(sfx, 1.0f);
    }



}
