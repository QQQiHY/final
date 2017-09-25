using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class npcpart : MonoBehaviour {
    public Text conv;
    public GameObject player;
    public GameObject back;
    public talkpart tk;
    public quest qt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(gameObject.transform.position, player.transform.position) < 3 && Input.GetKeyDown(KeyCode.E))
        {
            back.SetActive(true);
            conv.text = "I am the old hero, I know you want to find the sword of truth!";
        }
        if (conv.text == "I am the old hero, I know you want to find the sword of truth!" && Input.GetKeyDown(KeyCode.Y))
        {
            conv.text = "That is not easy!! Good luck!!";

        }
        if (conv.text == "That is not easy!! Good luck!!" && Input.GetKeyDown(KeyCode.O))
        {
            back.SetActive(false);
            tk.istalk = true;
            qt.Que.text = "Touch the stones";
            Color c = qt.Que.color;
            c.a = 1;
            qt.Que.color = c;
        }
    }
}
