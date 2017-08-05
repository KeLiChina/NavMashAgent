﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNav : MonoBehaviour {

	private NavMeshAgent m_NavMeshAgent;
	private Transform end_Transform;
	
	void Start () {
		m_NavMeshAgent = gameObject.GetComponent<NavMeshAgent>();
		end_Transform = GameObject.Find("End").GetComponent<Transform>();
		m_NavMeshAgent.SetDestination(end_Transform.position);
	}
	

}
