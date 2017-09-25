using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class quest : MonoBehaviour {
    public Text Que;
    public talkpart tk;
    public magicskilll mk;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        {
            if (tk.istalk == false)
            Que.text = "Go find the old hero";
            Color c = Que.color;
            c.a = c.a - 0.01f;
            Que.color = c;
            if (mk.istra == true)
            {
                Que.text = "Try to go next level!!";
                c = Que.color;
                c.a = c.a - 0.01f;
                Que.color = c;
            }
        }
	}
}
