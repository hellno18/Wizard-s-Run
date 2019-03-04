using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    public int damage=1;
    private ScoreCalc scorecalc;
    private Animator anim;
   

    // Use this for initialization
    void Start () {
        scorecalc = GameObject.Find("GameManager").GetComponent<ScoreCalc>();
        anim = GameObject.Find("Player").GetComponent<Animator>();
        StartCoroutine(delayDead());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if trigger with player
        if (collision.gameObject.tag == "Player")
        {
            collision.GetComponent<Player>().health -= damage;
            anim.SetBool("Hit", true);
            scorecalc.heart.fillAmount -= 0.3333333333333333f;
            scorecalc.source.PlayOneShot(scorecalc.sfxHit, 0.5f);
            //Debug.Log(collision.GetComponent<Player>().health);
            Destroy(gameObject);
            
        }
        //if trigger with destroy object
        if (collision.gameObject.tag=="Destroy")
        {
            Destroy(gameObject);
           
        }
    }
  
    IEnumerator delayDead()
    {
        yield return new WaitForSeconds(0.1f);
        anim.SetBool("Hit", false);
    }
}
