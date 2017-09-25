using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorhl : MonoBehaviour {
    public GameObject door;
    public bool go = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    void OnTriggerEnter(Collider other)
    {
        door.SetActive(false);
        go = true;
    }
}
