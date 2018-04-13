using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentAI : MonoBehaviour {
    private NavMeshAgent ThisAgent = null;
    private Transform PlayerTransform = null;

	// Use this for initialization
	void Start () {
        GameObject PlayrObject = GameObject.FindGameObjectWithTag("Player");
        PlayerTransform = PlayrObject.GetComponent<Transform>();
        ThisAgent = GetComponent<NavMeshAgent>();

	}
	
	// Update is called once per frame
	void Update () {
        ThisAgent.SetDestination(PlayerTransform.position);

		
	}
}
