using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour {

	private Transform m_Transform;
	private NavMeshAgent m_NavMeshAgent;
	private Ray ray;
	private RaycastHit hit;
	void Start () {
		m_Transform = gameObject.GetComponent<Transform>();
		m_NavMeshAgent = gameObject.GetComponent<NavMeshAgent>();
		
	}
	
	
	void Update () {
		PlayerMovByNav();
	}
	private void PlayerMovByNav()
	{
		
		if(Input.GetMouseButtonDown(0))
		{
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray,out hit))
			{
				m_NavMeshAgent.SetDestination(hit.point);
			}
		}
	}
}
