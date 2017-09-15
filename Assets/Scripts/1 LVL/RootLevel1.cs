using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RootLevel1 : MonoBehaviour
{
	//ENEMYS
	public GameObject barel;
	public GameObject wood;
	public GameObject stone;
	public GameObject fish;
	public GameObject kopiya;
	public float randEnemy;

    private GameObject kopiyaBarell;
    public GameObject barellBroken;

    public float timer;
	public float hardLvl = 4f;

	public GameObject OwlProgress;
	public bool victory;

	public int scores = 0;
	public Text txtScores;

	void Start ()
	{
	
	}

	void Update ()
	{
		timer = timer + 1f / 60f;
		randEnemy = Random.Range (0f, 1f); // how enemy create?
		hardLvl -= 0.0005f; //Uslognenie level


	
		//PROGRESS LEVEL 
		if (victory == false) {
			OwlProgress.transform.Translate (0.0015f, 0f, 0f);
			if (OwlProgress.transform.position.x >= 2.9f) {
				if (OwlProgress.transform.position.y >= -0.591f) {
					victory = true;
				}
			}
		}

		if (victory == true) {
			Debug.Log ("Victory");

            Application.LoadLevel("Victory");
		}




		//Creation ENEMYS 
		if (timer > hardLvl) {	
			//BAREL
			if (randEnemy <= 0.25f) {
				kopiya = GameObject.Instantiate (barel);
				kopiya.transform.position = new Vector3 (7.20f, Random.Range (-2.3f, 2.7f), 0f);
				timer = 0;
			}
			//WOOD
			if (randEnemy > 0.25f && randEnemy <= 0.5f) {
				kopiya = GameObject.Instantiate (wood);
				kopiya.transform.position = new Vector3 (7.20f, Random.Range (-2.3f, 2.7f), 0f);
				timer = 0;
			}
			//STONE
			if (randEnemy > 0.5f && randEnemy <= 0.75f) {
				kopiya = GameObject.Instantiate (stone);
				kopiya.transform.position = new Vector3 (7.20f, Random.Range (-2.3f, 2.7f), 0f);
				timer = 0;
			}
			//FISH
			if (randEnemy > 0.75f && randEnemy <= 1f) {
				kopiya = GameObject.Instantiate (fish);
				kopiya.transform.position = new Vector3 (7.20f, Random.Range (-2.3f, 2.7f), 0f);
				timer = 0;
			}
		}
	}



    void OnCollisionEnter2D(Collision2D col)
    {
        // BROKEN BARELL
        if (col.gameObject.tag == ("Player"))
        {
            kopiyaBarell = GameObject.Instantiate(barellBroken);
            kopiyaBarell.transform.position = this.transform.position;
        }
    }
}
