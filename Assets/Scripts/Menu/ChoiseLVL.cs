using UnityEngine;
using System.Collections;

public class ChoiseLVL : MonoBehaviour {

    public void FirstButton()
    {
        Application.LoadLevel("World1");
    }

    public void SecondLevel()
    {
        Application.LoadLevel("World2");
    }

    public void ThirdLevel()
    {
        Application.LoadLevel("World3");
    }
    public void Back()
    {
        Application.LoadLevel("Menu");
    }
}
