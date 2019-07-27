using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieHealth : MonoBehaviour
{
    float health = 3;
    private ParticleSystem Blood;
    // Use this for initialization
    void Start()
    {
        Blood = GetComponent<ParticleSystem>();
        Blood.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Coll");
        if (col.gameObject.tag == "Bullet")
        {
            Blood.Play();
            Debug.Log("Hit");
            health--;
            if (health <= 0)
            {
                gameObject.GetComponent<BoxCollider>().enabled = false;
                gameObject.GetComponent<NavMeshAgent>().enabled = false;
                gameObject.GetComponent<Animator>().enabled = false;
            }
        }
    }
}
