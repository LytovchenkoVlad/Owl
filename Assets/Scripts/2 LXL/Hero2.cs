using UnityEngine;
using System.Collections;

public class Hero2 : MonoBehaviour
{

	Rigidbody2D rb;
	bool groundCheck;
	public bool death;
	public GameObject blood;
	float timer; //check for death and reload Level
    float timer2; // stun effect
    Animator anim;
    bool control = true;

    public GameObject stunEffect;

    void Start ()
	{
        rb =this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
	}

	void Update ()
	{

        if (Input.GetKeyDown("escape"))
        {
            Application.LoadLevel("Menu");
        }

        //HERO CONTROLLER
        //JUMP
        if (control == true)
        {
            if (groundCheck == true)
            {
                if (Input.GetKeyDown("w"))
                {
                    anim.Play("Fly");  //FLY ANIMATION
                    rb.AddForce(new Vector3(0f, 30000f, 0f));
                    groundCheck = false;
                }
            }
            if (Input.GetKey("d"))
            {
                rb.AddForce(new Vector3(600f, 0f, 0f));
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(new Vector3(-600f, 0f, 0f));
            }

            //RUN ANIMATION
            if (groundCheck == true)
            {
                anim.Play("Run");
            }
        }

        //STUN ANIMATION & Cessation of traffic
        if (control == false)
        {
            timer2 = timer2 + 1f / 60f;
        }
        if (timer2 > 1.5f)
        {
            control = true;
            timer2 = 0;
            stunEffect.SetActive(false);
        }

        //CHECK FOR DEATH
        if (this.transform.position.y <= -4.5f) {
			death = true;
			timer = timer + 1f/60f; // timer In the event of a fall 
        }
		if (death == true) {
			blood.SetActive (true);
            timer = timer + 1f / 60f; // timer for beast touch & death
            if (timer > 2.5f) {
                Debug.Log("TIMER DEATH");
				Application.LoadLevel ("World2");
			}
		}
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		groundCheck = true;

        if(col.gameObject.tag == ("Let"))
        {
            control = false;
            stunEffect.SetActive(true);
        }
        if (col.gameObject.name.Contains("Chest")) {
            Application.LoadLevel("Victory");
        }
     
    }
}
