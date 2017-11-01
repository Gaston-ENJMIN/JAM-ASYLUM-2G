using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {

    // Rayon de la sphère qui détecte le joueur
    public float lookRadius = 10f;

    // On définit ce que l'enemy doit suivre (target), et on charge le navmesh de l'enemy
    public Transform target;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        // On calcule la distance entre la position de l'enemy et celle de target
        float distance = Vector3.Distance(target.position, transform.position);

        // Si la distance est inférieure au rayon de la sphère
        if (distance <= lookRadius)
        {
            // Alors la destination de l'enemy va être la position de target
            agent.SetDestination(target.position);

            if (distance <= agent.stoppingDistance)
            {
                // L'enemy doit être face à target au contact
                FaceTarget();
            }
        }
	}

    void FaceTarget ()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
