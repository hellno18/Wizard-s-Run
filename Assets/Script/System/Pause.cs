using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private bool canPause;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); 
        canPause = true;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

        }
    }
    public void PauseButton()
    {
        if (canPause)
        {
            //pause
            Time.timeScale = 0;
            canPause = false;
            
        }
        else if (!canPause)
        {
            //!pause
            Time.timeScale = 1;
            canPause = true;
        }

    }
}
