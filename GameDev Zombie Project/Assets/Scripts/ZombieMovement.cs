using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMovement : MonoBehaviour {

    private NavMeshAgent mob;

    public GameObject Player;

    public float MobDistanceRun = 4.0f;
	// Use this for initialization
	void Start () {
        mob = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
		 
        if (distance < MobDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 NewPos = transform.position - dirToPlayer;
            mob.SetDestination(NewPos);
        }
	}
}
