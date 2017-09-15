using UnityEngine;
using System.Collections;

public class TestZombie : MonoBehaviour {

    float speed;
    Vector3 napravlenie;


    void Start () {
	
	}
	

	void Update () {
        if (Input.GetKey("d"))
        {
            this.transform.Translate(new Vector3(0f, 0.15f, 0f));
            this.transform.localRotation = Quaternion.Euler(0f, 0f, -90f);
        }
        if (Input.GetKey("a"))
        {
            this.transform.Translate(new Vector3(0f, 0.15f, 0f));
            this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
        }
      
    }
}
