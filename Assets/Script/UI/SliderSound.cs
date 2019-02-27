using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSound : MonoBehaviour
{
    private Slider sound;
    private float soundPoint;
  
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<Slider>();
        sound.value = PlayerPrefs.GetFloat("SoundState");
    }

    // Update is called once per frame
    void Update()
    {
        if (sound.interactable)
        {
            GameObject OptionBar = GameObject.Find("GameManager");
            AudioSource audiosource = OptionBar.GetComponent<AudioSource>();
            audiosource.volume = sound.value;
            //set volume BGM
            PlayerPrefs.SetFloat("SoundState", sound.value);
        }
    }

}
