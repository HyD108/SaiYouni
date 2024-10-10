using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMessAI : MonoBehaviour
{
    public Transform targetToMove;
    [SerializeField] public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        this.agent.SetDestination(targetToMove.position);       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
