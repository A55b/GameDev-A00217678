using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCollider : MonoBehaviour {
   
    GameObject health;
    int dmg;
    // Use this for initialization
    void Start () {
        health = GameObject.Find("HEALTH");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        //Debug.Log("Coll");
        if (col.gameObject.tag == "Zattack")
        {
            dmg = Random.Range(18, 25);
            Debug.Log("PlayerHit");
            health.GetComponent<PlayerHealth>().HealthAdjust(dmg);
        }
    }
}
