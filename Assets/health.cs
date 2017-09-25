using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class health : MonoBehaviour {
    public int life = 5;
    public AudioClip hit;
    public GameObject player;
    public GameObject full;
    public GameObject onb;
    public GameObject half;
    public GameObject loh;
    public GameObject ded;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (life == 5)
        {
            full.SetActive(true);
            onb.SetActive(false);
            half.SetActive(false);
            loh.SetActive(false);
            ded.SetActive(false);
        }
        if (life == 4)
        {
            full.SetActive(false);
            onb.SetActive(true);
            half.SetActive(false);
            loh.SetActive(false);
            ded.SetActive(false);
        }
        if (life == 3)
        {
            full.SetActive(false);
            onb.SetActive(false);
            half.SetActive(true);
            loh.SetActive(false);
            ded.SetActive(false);
        }
        if (life == 2)
        {
            full.SetActive(false);
            onb.SetActive(false);
            half.SetActive(false);
            loh.SetActive(true);
            ded.SetActive(false);
        }
        if (life == 1)
        {
            full.SetActive(false);
            onb.SetActive(false);
            half.SetActive(false);
            loh.SetActive(false);
            ded.SetActive(true);
        }
        if (life == 0)
        {
            SceneManager.LoadScene("part2");
        }
    }
    public void TakDam()
    {
        GetComponent<AudioSource>().PlayOneShot(hit);
        life = life-1;
    }
    
}
