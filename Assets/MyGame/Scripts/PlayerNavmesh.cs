using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavmesh : MonoBehaviour {

    [SerializeField] private Transform movePositionTransform;
    private NavMeshAgent navMeshAgent;  

private void Awake()
    {
        GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        navMeshAgent.destination = movePositionTransform.position;
    }
}
