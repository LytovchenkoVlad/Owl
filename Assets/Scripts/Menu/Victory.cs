using UnityEngine;
using System.Collections;

public class Victory : MonoBehaviour {
    float timer;
	
	void Start () {
	
	}
	

	void Update () {
        timer = timer + 1 / 60f;
        if(timer > 4f)
        {
            Application.LoadLevel("ChoiceLVL");
        }
        //if(Input.GetKeyDown("space"))
        //{
        //    Application.LoadLevel("ChoiseLVL");
        //}
	}
}
