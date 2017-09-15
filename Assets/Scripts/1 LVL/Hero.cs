using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{

	Rigidbody2D rb;

	public GameObject fireBall;
	private GameObject kopiya; // FIRE BALLS
    int counterFireBall = 5;

    private GameObject kopiyaBarell;  //BROKEN BARELL
    public GameObject brokenBarell;
    
	float timer;  // TIME
    float timer2;

    public Text txtCounterForeBall;  //TEXT
	public Text txtTimer;

    public GameObject[] hearts;
	int counterHearts;  //HEARTS

    bool death;
	public RootLevel1 rootLevel; //OTHER
    public GameObject blood;

    void Start ()
	{
		counterHearts = 4;
        rb = GetComponent<Rigidbody2D>();
         
	}

	void Update ()
	{

        if (Input.GetKeyDown("escape"))
        {
            Application.LoadLevel("Menu");
        }


        //Hero controll 
        if (Input.GetKey ("w")) {
			rb.AddForce (new Vector3 (0f, 40f, 0f)); //сила с которой двигается герой вверх

		}
		if (Input.GetKey ("s")) {
			rb.AddForce (new Vector3 (0f, -40f, 0f)); //сила с которой двигается герой вниз
		}
		timer = timer + 1f / 60f;
		// if 10 sec. add one fireBall
		if (timer >= 10f) {  
			counterFireBall++;
			timer = 0;
		}

		//output on display counter FireBall
		txtCounterForeBall.text ="" + counterFireBall;
		txtTimer.text =timer.ToString("0.0") + "/10sec";


		//Shooting FireBall
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			//Shooting restriction
			if (counterFireBall > 0 && counterFireBall < 10) { 
				counterFireBall--;
				kopiya = GameObject.Instantiate (fireBall);
				kopiya.transform.position = this.transform.position;

			}
		}

		//DEATH
		if(death == true){
            blood.SetActive(true);
            timer2 = timer2 + 1f / 60f; // timer for beast touch & death
            if (timer2 > 2.5f)
            {
                Application.LoadLevel("World1");
            }

        }
	}

	
	void OnCollisionEnter2D(Collision2D col){
        
        //SET ACTIVE HEALTH BAR'S (O O O)
        if (col.gameObject.tag == ("enemy")){
		//	Destroy(col.gameObject);
			hearts[0].SetActive (false);
			counterHearts -= 1;
		}
		if(col.gameObject.tag == ("enemy") && counterHearts ==2){
			//Destroy(col.gameObject);
			hearts[1].SetActive (false);
		}
		if(col.gameObject.tag == ("enemy") && counterHearts ==1){
		//	Destroy(col.gameObject);
			hearts[2].SetActive (false);
			death = true;
		}


	}
}
