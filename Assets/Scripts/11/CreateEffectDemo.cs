using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEffectDemo : MonoBehaviour {

	public GameObject prefab_Arrow;

	
	
	void Update () {
		CreateEff();
	}
	private void CreateEff()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			GameObject go = Instantiate(prefab_Arrow,Vector3.zero,Quaternion.identity);
			go.GetComponent<ArrowEffectManager>().PlayEffect();
			GameObject.Destroy(go,1f);
		}
	}
}
