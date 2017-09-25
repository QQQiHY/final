using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gettra : MonoBehaviour {
    public GameObject player;
    public magicskilll ms;
    public GameObject fl;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) < 4 && Input.GetKeyDown(KeyCode.E) && ms.isele==true && ms.isice == true && ms.isfire == true)
        {
            ms.istra = true;
            fl.SetActive(false);
        }
    }
}
