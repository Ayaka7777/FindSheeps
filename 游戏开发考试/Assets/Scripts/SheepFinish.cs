using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEditor;


public class SheepFinish : MonoBehaviour
{
    private GameObject flag;
    private Animator ani;
    public int point;
    public int Point
    {
        get
        { return point; }
    }

    void Start()
    {
        flag = GameObject.FindGameObjectWithTag("Finish");
        ani = GetComponent<Animator>();
        point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(this.transform.position,flag.transform.position)<1.5f)
        {
            ani.SetInteger("walk", 0);
            Destroy(GetComponent<Rigidbody>());
            Destroy(GetComponent<AnimalController>());
            Destroy(GetComponent<BoxCollider>());
            Destroy(GetComponent<NavMeshAgent>());
            point = 1;
        }
    }
}
