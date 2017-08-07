using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour {

	private NavMeshAgent  m_NavMeshAgent;
	private Transform player_Transform;
	void Awake () {
		m_NavMeshAgent = gameObject.GetComponent<NavMeshAgent>();
		// m_NavMeshAgent.SetDestination();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void SetTarget(string playername)
	{
		player_Transform = GameObject.Find(playername).GetComponent<Transform>();
		m_NavMeshAgent.SetDestination(player_Transform.position);
	}
}
