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
			if( i <= 2)
			{
				//  temp = GameObject.Instantiate(prefab_AAA,points[i].position,Quaternion.identity);
		        //  Monster monster = temp.AddComponent<Monster>();
			    //  monster.SetTarget(playername,2f);
				CreateMonster(2f,i,prefab_AAA);
			}
			else
			{
				//  temp = GameObject.Instantiate(prefab_BBB,points[i].position,Quaternion.identity);
				//  Monster monster = temp.AddComponent<Monster>();
				//  monster.SetTarget(playername,5f);
				CreateMonster(5f,i,prefab_BBB);
			}

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
	private void CreateMonster(float dis,int index,GameObject prefab)
	{
		GameObject temp = GameObject.Instantiate(prefab,points[index].position,Quaternion.identity);
		Monster monster = temp.AddComponent<Monster>();
		monster.SetTarget(playername,dis);
		temp.transform.SetParent(m_Transform);			
		monsterList.Add(temp);
	}
}
