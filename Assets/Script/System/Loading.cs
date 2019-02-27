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

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if(currentAmount<100)
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
