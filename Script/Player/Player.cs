using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float incrementX;
    public float maxWidth = 5f;
    public float minWidth = -5f;
    public int health = 3;
    public GameObject effect;
    public GameObject effectbad;
    ScoreCalc scorecalc;
    public float speed=0;
    public AudioClip sfxRight;
    public AudioClip sfxLeft;
    private Animator anim;
    private AudioSource source;
    // Use this for initialization
    void Start()
    {
        this.gameObject.SetActive(true);
        scorecalc = GameObject.Find("GameManager").GetComponent<ScoreCalc>();
        anim = GameObject.Find("Player").GetComponent<Animator>();
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //if player health below 0, player died
        if (health <= 0)
        {
 
            anim.SetBool("Dead", true);
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            //while died, give little delay
            StartCoroutine(deadDelay());
        }
        //input right 
        if (Input.GetKeyDown(KeyCode.RightArrow)|| Input.GetKeyDown(KeyCode.D))
        {
            InputRight();

        }
        //input left
        if (Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.A))
        {
            InputLeft();
        }

    }

    public void InputLeft()
    {
        if (transform.position.x > minWidth)
        {
            anim.SetBool("Left", true);
            //set volume SE
            source.volume = PlayerPrefs.GetFloat("SoundState");
            source.PlayOneShot(sfxLeft, 1f);
            //change position
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x - incrementX, transform.position.y);
            transform.position = targetPos;
            //delay time
            StartCoroutine(delay());

        }

    }
    public void InputRight()
    {
        if (transform.position.x < maxWidth)
        {
            anim.SetBool("Right", true);
            //set volume SE
            source.volume = PlayerPrefs.GetFloat("SoundState");
            source.PlayOneShot(sfxRight, 1f);
            //change position
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x + incrementX, transform.position.y);
            transform.position = targetPos;
            //delay time
            StartCoroutine(delay());

        }

    }

    //while triggered with obstacle
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstacle"))
        {
            Instantiate(effectbad, transform.position, Quaternion.identity);
            scorecalc.getScore(-1);

        }

    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.1f);
        //Debug.Log("delay");
        anim.SetBool("Right", false);
        anim.SetBool("Left", false);
    }
    IEnumerator deadDelay()
    {
        effect.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        //effectbad.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(1.2f);
        effect.gameObject.GetComponent<BoxCollider2D>().enabled = true;
        this.gameObject.SetActive(false);
        
    }
}
