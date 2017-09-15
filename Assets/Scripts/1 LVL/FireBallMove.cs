using UnityEngine;
using System.Collections;

public class FireBallMove : MonoBehaviour {

	public Rigidbody2D rb;
	public float timer;
	public GameObject force;
	public GameObject kopiya;
	public RootLevel1 rootLevel;


	void Start () {
	
	}
	void Update () {
		rb.AddForce(new Vector3 (60f,0f,0f));
		timer = timer + 1f / 60f;
		if(timer >  3f) {
			Destroy(this.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.tag ==("enemy")){
			Destroy(col.gameObject);
			Destroy(this.gameObject);
			kopiya = GameObject.Instantiate (force);
			kopiya.transform.position = this.transform.position;

		}
	}
}
