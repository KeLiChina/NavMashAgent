using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour {

	void OnTriggerEnter(Collider coll)
	{
		if (coll.tag == "Monster")
		{
			Destroy(gameObject);
			coll.GetComponent<Monster>().Alive = false;
			Destroy(coll.gameObject);
		}
	}
}
