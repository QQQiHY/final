using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getfire : MonoBehaviour {
    public GameObject player;
    public magicskilll ms;
    public GameObject fl;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) < 4 && Input.GetKeyDown(KeyCode.E))
        {
            ms.isfire = true;
            fl.SetActive(false);
        }
    }
}
