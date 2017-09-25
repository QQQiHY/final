using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class finaltouch : MonoBehaviour {
	public GameObject player;
	public GameObject ima;
	public Image im;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(gameObject.transform.position, player.transform.position) < 3 && Input.GetKeyDown(KeyCode.E))
		{
			ima.active = true;
			Color c = im.color;
			c.a = 1;
			im.color = c;
			SceneManager.LoadScene ("part4");
		}
	}
}
