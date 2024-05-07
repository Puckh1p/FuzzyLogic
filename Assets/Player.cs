using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] destinations;

    public int i = 0;


    void Start()
    {
        navMeshAgent.destination = destinations[0].transform.position;
    }

    void Update()
    {

    }
}
