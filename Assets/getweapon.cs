using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class getweapon : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(gameObject.transform.position, player.transform.position) < 5 && Input.GetKeyDown(KeyCode.G))
		{
			gameObject.active = false;
			SceneManager.LoadScene("part2");
		}
	}
}