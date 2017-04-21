using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
	Animator anim;

	private EnemyHealth enemyHealth;
    
	NavMeshAgent agent;
	public Transform target;

	void Start(){
		
		anim = GetComponent<Animator> ();
		agent = GetComponent<NavMeshAgent> ();
		//GameObject Target = GameObject.FindGameObjectWithTag("Player");
		//target = Target.transform;
	}

	void Update()
	{
		GameObject Target = GameObject.FindGameObjectWithTag("Player");
		anim.SetBool ("isRun", true);

		target = Target.transform;


		if (target != null) {
			
			agent.SetDestination (target.position);

		}


	}


}