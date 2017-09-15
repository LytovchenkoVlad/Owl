using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hero3 : MonoBehaviour
{
    Rigidbody2D rb;
    bool groundCheck;
    public bool death;
    public GameObject blood;
  public  float timer; //check for death and reload Level
    Animator anim;
    bool control = true;

    public int hearts = 10;
    Text txtCounterHearts;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
        txtCounterHearts = GameObject.Find("txtCounterHearts").GetComponent<Text>();
    }

    void Update()
    {

        if (Input.GetKeyDown("escape"))
        {
            Application.LoadLevel("Menu");
        }
        //HERO CONTROLLER
        //JUMPING DOWN
        if (control == true)
        {
            if (groundCheck == true)
            {
                if (Input.GetKeyDown("w"))
                {
                    rb.AddForce(new Vector3(0f, 35000f, 0f));
                    groundCheck = false;
                }
            }
            if (Input.GetKey("d"))
            {
                rb.AddForce(new Vector3(1000f, 0f, 0f));
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(new Vector3(-1000f, 0f, 0f));
            }
            timer = timer + 1f / 60f; // timer for WallKiller touch & death
        }

        //HEARTS
        txtCounterHearts.text = "" + hearts; // Output on screen counters hearts
        if(hearts < 1)
        {
            Death();
        }
    }


    public void Death() // LOADING IF DEATH
    {
        //timer = 0;
      
        death = true;
        if (death == true)
        {
            blood.SetActive(true);
            control = false;

            if (timer > 2.5f)
            {
                Debug.Log("TIMER DEATH");
                Application.LoadLevel("World3");
            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        groundCheck = true; //touch with ground

        //CHEKING WINS
        if (col.gameObject.name.Contains("Chest"))
        {
            Application.LoadLevel("Victory");
        }

        //IF EXTENDED SPEED
        if (col.relativeVelocity.y < -10f)
        {
            Debug.Log("MINUS HEART1");
            hearts--;
        }

        //IF TOUCH WITH WALL DOWN
        if(col.gameObject.name == ("WallDeath"))
        {
            Application.LoadLevel("World3");
        }
    }

    void OnTriggerEnter2D(Collider2D cols) {
        if (hearts < 10)
        {
            if (cols.gameObject.tag == ("hearts"))
            {
                Destroy(cols.gameObject);
                
                hearts++;
            }
        }

    }
}