using UnityEngine;
using System.Collections;

public class EnemyControll : MonoBehaviour {

	public Rigidbody2D rb;
	public float timer;

	void Start () {
	
	}
	

	void Update () {
		rb.AddForce(new Vector3 (-60f,0f,0f));
		timer = timer + 1f / 60f;
		if(timer >  5f) {
			Destroy(this.gameObject);
		}
		this.transform.Rotate(0f,0f,1f);

	}
}
