using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class att : MonoBehaviour
{
    public doorhl dl;
    public Transform player;
    public GameObject bullet;
    public GameObject bulletSpawn;
    public GameObject player1;
    float countdown = -1;

    public float dist;
    void Update()
    {
        NavMeshAgent nm = GetComponent<NavMeshAgent>();
        dist = Vector3.Distance(player.transform.position, gameObject.transform.position);

        if (dl.go == true)
        {
            countdown = countdown - Time.deltaTime;
            if (countdown < 0)
            {
                countdown = 0.8f;
                GameObject obj = (GameObject)Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
                obj.GetComponent<Rigidbody>().velocity = Vector3.right * 20;
                Destroy(obj, 1.0f);
            }
        }
    }
}
