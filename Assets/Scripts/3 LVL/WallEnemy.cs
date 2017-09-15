using UnityEngine;
using System.Collections;

public class WallEnemy : MonoBehaviour {

    public Hero3 hero;
    Rigidbody2D rb;
    Vector3 napravlenieDown;

	void Start () {
        rb = this.GetComponent<Rigidbody2D>(); 
        napravlenieDown = new Vector3(0f, -0.7f, 0f);
	}
	

	void Update () {
       rb.AddForce(napravlenieDown * 1.2f); // Moving wall down

	}

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.name.Contains("Owl")) //IF TOUCH WALL TO HERO
        {
            Debug.Log("DEATH");
            hero.Death();
        }
    }
}
