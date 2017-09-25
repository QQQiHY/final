using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
    public GameObject bull;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            GameObject b = (GameObject)Instantiate(bull, transform.position, transform.rotation);
            b.GetComponent<Rigidbody>().velocity = transform.forward * 15;
        }
	}
}
