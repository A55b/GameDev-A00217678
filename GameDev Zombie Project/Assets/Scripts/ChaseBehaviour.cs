using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChaseBehaviour : StateMachineBehaviour
{
    private GameObject Nav;
    private GameObject player;
    public float MobDistanceRun = 4.0f;
    public float Speed = 1.0f;
    private NavMeshAgent mob;
    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("chase");
        player = GameObject.FindGameObjectWithTag("Player");
        mob = animator.transform.root.GetComponent<NavMeshAgent>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Vector3 dirToPlayer = animator.transform.position - player.transform.position;
        Vector3 NewPos = animator.transform.position - dirToPlayer;
        mob.SetDestination(NewPos);
        //animator.transform.position = Vector3.MoveTowards(animator.transform.position, player.transform.position, Speed * Time.deltaTime);
        float distance = Vector3.Distance(animator.transform.position, player.transform.position);
        if (distance > MobDistanceRun)
        {
            animator.SetBool("isFollowing", false);
          
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

    // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

}