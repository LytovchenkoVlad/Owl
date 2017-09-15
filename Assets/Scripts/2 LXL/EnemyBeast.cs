using UnityEngine;
using System.Collections;

public class EnemyBeast : MonoBehaviour {

	Hero2 hero;
    float speed = 1.2f;

	void Start () {
        hero = GameObject.Find("Hero").GetComponent<Hero2>();
	}
	void Update () {
		this.transform.Translate (0.03f,0f, 0f);
	}

void OnCollisionEnter2D(Collision2D col){
	if(col.gameObject.name == ("Hero")){
			hero.death = true;	
		}
	}
}
