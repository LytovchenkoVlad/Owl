using UnityEngine;
using System.Collections;

public class MovinCam3 : MonoBehaviour {

    public GameObject Hero;
    public Vector3 napravlenie;
    Rigidbody2D rb;


    void Start()
    {
     //   HeroOwl = GameObject.Find("Owl").GetComponent<Hero3>();
        rb = this.GetComponent<Rigidbody2D>(); 

    }


    void Update()
    {
        napravlenie = Hero.transform.position - this.transform.position;
        napravlenie = napravlenie.normalized;
        rb.AddForce(napravlenie * 70);
    }
}
