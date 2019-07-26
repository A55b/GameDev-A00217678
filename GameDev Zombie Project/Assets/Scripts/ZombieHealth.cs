using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieHealth : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Coll");
        if (col.gameObject.tag == "Bullet")
        {
            Debug.Log("Hit");

            gameObject.GetComponent<NavMeshAgent>().enabled = false;
            gameObject.GetComponent<Animator>().enabled = false;
        }
    }
}
