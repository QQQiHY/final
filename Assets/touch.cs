using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour {
	public GameObject player;
	public GameObject light;
	public GameObject text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(gameObject.transform.position, player.transform.position) < 5 && Input.GetKeyDown(KeyCode.Alpha0))
		{
			text.active = true;
			light.active = true;
		}
	}
}
