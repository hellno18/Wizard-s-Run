using System.Collections;
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
    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
        source.PlayOneShot(sfx, 1.0f);
        //SceneManager.GetActiveScene().buildIndex + 1
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

    
}
