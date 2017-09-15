using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {

	}

	public void StartButton(){

        Application.LoadLevel("ChoiceLVL");
	}

	public void OptionsButton(){
		Debug.Log("POKA NET TAKOGO");
	}

	public void ExitButton(){
		Debug.Log("Exit");
		Application.Quit();
	}
}
