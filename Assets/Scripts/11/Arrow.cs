using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

	private Transform m_Transoform;
	void Start () {
		m_Transoform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		RotateArrow();
	}
	private void RotateArrow()
	{
		m_Transoform.Rotate(new Vector3(360 * Time.deltaTime,0,0));
	}
}
