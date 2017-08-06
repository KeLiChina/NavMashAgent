using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {

	public int index;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider coll)
	{
		object id = index;
		if( coll.name =="Necromancer")
		{
			SendMessageUpwards("TriggerEnter",id);
		}
	}
}
