using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor;

public class AnimalController : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject player;
    private bool aaa;
    private Animator ani;

    void Start()
    {
        ani = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        aaa = false;
    }

    void OnMouseDown()
    {
        aaa = true;
    }
    private void Update()
    {
        var distanceToTarget = Vector3.Distance(transform.position, player.transform.position);
        if(aaa == true && distanceToTarget > 1 && distanceToTarget <5)
        {
            agent.destination = player.transform.position;
            ani.SetInteger("walk", 1);
        }
        else if(distanceToTarget <= 1 || distanceToTarget >= 5)
        {
            agent.destination = this.transform.position;
            ani.SetInteger("walk", 0);
        }
    }
}
