using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour {
    public Transform LoadingBar;
    [SerializeField]
    private float currentAmount;
    [SerializeField]
    private float speed;
    private float volume;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //get volume
        volume= PlayerPrefs.GetFloat("SoundState");
        gameObject.GetComponent<AudioSource>().volume = volume;
        if (currentAmount<100)
        {
            currentAmount += speed * Time.deltaTime;
        }
        else
        {
            Application.LoadLevel("MainMenu");
        }

        LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
	}
}
