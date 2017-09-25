using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class magicskilll : MonoBehaviour {
    // Use this for initialization
    public GameObject ele;
    public GameObject ice;
    public GameObject fire;
    public GameObject tra;
    public bool istra = false;
    public bool isele = false;
    public bool isfire = false;
    public bool isice = false;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isele == true && Input.GetKeyDown(KeyCode.Alpha1))
        {
            ele.SetActive(true);
            fire.SetActive(false);
            ice.SetActive(false);
            tra.SetActive(false);
        }
        if (isfire == true && Input.GetKeyDown(KeyCode.Alpha2))
        {
            fire.SetActive(true);
            ele.SetActive(false);
            ice.SetActive(false);
            tra.SetActive(false);
        }
        if (isice == true && Input.GetKeyDown(KeyCode.Alpha3))
        {
            ice.SetActive(true);
            ele.SetActive(false);
            fire.SetActive(false);
            tra.SetActive(false);
        }
        if (istra == true && Input.GetKeyDown(KeyCode.Alpha4))
        {
            tra.SetActive(true);
            ice.SetActive(false);
            ele.SetActive(false);
            fire.SetActive(false);
        }
    }
}
