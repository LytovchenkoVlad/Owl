using UnityEngine;
using System.Collections;

public class MovingCamera : MonoBehaviour {

	GameObject Hero;
	public Vector3 napravlenie;
	Rigidbody2D rb;


	void Start () {
        Hero = GameObject.Find("Hero");
        rb = GetComponent<Rigidbody2D>();
	}

	void Update () {
		napravlenie = Hero.transform.position - this.transform.position;
		napravlenie = napravlenie.normalized;
		rb.AddForce(napravlenie * 70);
	}
}
