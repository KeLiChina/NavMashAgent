using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.AI;

public class MonsterManager : MonoBehaviour {

	private Transform m_Transform;
	private Transform[] points;
	private GameObject prefab_AAA;
	private GameObject prefab_BBB;
	private string playername = "Necromancer";
	private List<GameObject> monsterList = new List<GameObject>();
	void Start () {
		m_Transform = gameObject.GetComponent<Transform>();
		points = GameObject.Find("CreatePoints").GetComponent<Transform>()
		.GetComponentsInChildren<Transform>();
		prefab_AAA = Resources.Load<GameObject>("AAA");
		prefab_BBB = Resources.Load<GameObject>("BBB");
		
	}
	
	private void CreateMonsters()
	{
		for (int i = 1; i < points.Length; i++)
		{
			GameObject temp = GameObject.Instantiate(prefab_AAA,points[i].position,Quaternion.identity);
			Monster monster = temp.AddComponent<Monster>();
			monster.SetTarget(playername);
			monsterList.Add(temp);
			// temp.GetComponent<NavMeshAgent>().SetDestination();
			
		}
	}
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.C))
		{
			CreateMonsters();
		}
	}
}
