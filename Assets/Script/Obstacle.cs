using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    public int damage=1;
    private ScoreCalc scorecalc;
   

    // Use this for initialization
    void Start () {
        scorecalc = GameObject.Find("GameManager").GetComponent<ScoreCalc>();
       
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Player>().health -= damage;
            scorecalc.heart.fillAmount -= 0.3333333333333333f;
            scorecalc.source.PlayOneShot(scorecalc.sfxHit, 0.5f);
            Debug.Log(collision.GetComponent<Player>().health);
            Destroy(gameObject);
        }
        if (collision.CompareTag("Destroy"))
        {
            Destroy(gameObject);
           
        }
    }
}
