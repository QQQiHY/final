using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class follow : MonoBehaviour {
	public Transform wom;
	public float dd;
	public GameObject talkk;
    public GameObject end;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		NavMeshAgent nn = GetComponent<NavMeshAgent>();
		dd = Vector3.Distance (gameObject.transform.position, wom.transform.position);
		if (dd > 3) {
			GetComponent<Animator> ().SetBool ("isclo", false);
			nn.Resume ();
			nn.SetDestination (wom.transform.position);
		} else {
			GetComponent<Animator> ().SetBool ("isclo", true);
			nn.Stop();
			talkk.active = true;
		}
        if (talkk.active == true && Input.GetKeyDown(KeyCode.Alpha9))
        {
            end.SetActive(true);
        }
	}
}
