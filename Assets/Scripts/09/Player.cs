using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour {

	private Transform m_Transform;
	private NavMeshAgent m_NavMeshAgent;
	private Ray ray;
	private RaycastHit hit;
	public GameObject prefabs_Arrow;
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
				CreateArrow(hit.point);
				
			}
		}
	}
	private void CreateArrow(Vector3 pos)
	{
		Vector3 temp = pos + new Vector3(0,0.5f,0);
		
		GameObject go = Instantiate(prefabs_Arrow,temp,Quaternion.identity);
		go.GetComponent<ArrowEffectManager>().PlayEffect();
		GameObject.Destroy(go,1f);
	}
}
