﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getatt : MonoBehaviour {
    public GameObject mons;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        mons.SetActive(false);
    }
}
