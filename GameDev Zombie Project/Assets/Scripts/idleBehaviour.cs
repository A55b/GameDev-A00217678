using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idleBehaviour : StateMachineBehaviour {
    private Vector3 playerPos;
    public float MobDistanceRun = 4.0f;
    
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        Debug.Log("Idle");
        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
	}

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        float distance = Vector3.Distance(animator.transform.position, playerPos);

        if (distance < MobDistanceRun)
        {
            Debug.Log("Idle");
            animator.SetBool("isFollowing", true);
            //Vector3 dirToPlayer = transform.position - Player.transform.position;
            //Vector3 NewPos = transform.position - dirToPlayer;
            //mob.SetDestination(NewPos);
        }
    }

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	//override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
	//override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}

	// OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
	//override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	//
	//}
}
