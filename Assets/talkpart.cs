using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkpart : MonoBehaviour {
    public bool istalk = false;
    public GameObject doorcl;
    public GameObject doorop;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (istalk == true)
        {
            doorcl.SetActive(false);
            doorop.SetActive(true);
        }
	}
}
