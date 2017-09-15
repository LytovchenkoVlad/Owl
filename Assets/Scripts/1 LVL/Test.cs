using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
	public float[] zp;
	public GameObject owl;
	public GameObject kopiya;
	public GameObject zagotovka;
	public Vector3 kor;

	void Start ()
	{

		for (int x = 0; x < 10; x++) {
			for (int y=0; y<10; y++) {
				kopiya = GameObject.Instantiate (zagotovka);
				kopiya.transform.position = kor;
				kor.x = x;
				kor.y = y;
				kopiya.transform.rotation = Quaternion.Euler (0f, 0f, Random.Range(0,360));
			}
		}
	}

}
