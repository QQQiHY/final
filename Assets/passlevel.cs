using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class passlevel : MonoBehaviour {
	public bool pass = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (pass == true) 
		{
			SceneManager.LoadScene("part3");
		}
			
	}
}
