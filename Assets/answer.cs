using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answer : MonoBehaviour {
    public GameObject magic;
    public GameObject lit; 
	public passlevel pl;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider magic)
    {
        lit.active = true;
		pl.pass = true;
    }
}
