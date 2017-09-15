using UnityEngine;
using System.Collections;

public class DestroyForce : MonoBehaviour {

	public float timer;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer = timer +1f/60f;
		if(timer >=2.5f){
			Destroy(this.gameObject);
		}
	}
}
