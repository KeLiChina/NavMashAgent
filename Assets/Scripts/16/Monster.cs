using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour {

	private NavMeshAgent  m_NavMeshAgent;
	private Transform m_Transform;
	private Transform player_Transform;
	private float distance;
	private bool alive = true;
	public bool Alive{
		get{return alive;}
		set{alive = value;
			SendMessageUpwards("UpdateMonsterList",gameObject);
		}
	}
	void Awake () {
		m_NavMeshAgent = gameObject.GetComponent<NavMeshAgent>();
		m_Transform = gameObject.GetComponent<Transform>();
		// m_NavMeshAgent.SetDestination();
	}
	
	// Update is called once per frame
	void Update () {
		// FollowNavigation();
	}
	public void SetTarget(string playername,float dis)
	{
		player_Transform = GameObject.Find(playername).GetComponent<Transform>();
		m_NavMeshAgent.SetDestination(player_Transform.position);
		distance = dis;
		m_NavMeshAgent.stoppingDistance = distance;
		StartCoroutine(FollowNav(alive,0.5f));
	}
	private void FollowNavigation()
	{
		if (Vector3.Distance(m_Transform.position,player_Transform.position) > distance)
		{
			m_NavMeshAgent.SetDestination(player_Transform.position);
		}
		// else
		// {
			
		// }
	}
	IEnumerator FollowNav(bool bl,float offtime)
	{
		while(bl)
		{
			
			if (Vector3.Distance(m_Transform.position,player_Transform.position) > distance)
			{
				m_NavMeshAgent.SetDestination(player_Transform.position);
			}
			yield return new WaitForSeconds(offtime);
		}
	}
}
