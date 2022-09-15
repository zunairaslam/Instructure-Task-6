using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PathFollow : MonoBehaviour
{
    public Transform objectToReach;
    public float moveSpeed = 10f;
    private NavMeshAgent NavMeshAgent;
    public bool isFollow;
    public static PathFollow pathFollow;

    private void Awake()
    {
        if(pathFollow == null)
        {
            pathFollow= this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollow)
        {
            Debug.Log("the thing");
            NavMeshAgent.destination = objectToReach.position * moveSpeed * Time.deltaTime;
            transform.LookAt(objectToReach.position);
            Quaternion.LookRotation(objectToReach.position);
        }
    }

    
}
