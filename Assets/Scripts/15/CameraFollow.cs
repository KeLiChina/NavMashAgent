using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	private Transform m_Transform;
	private Transform player_Transform;
	private Vector3 offset;
	public float speed = 3f;
	// private Vector3 temp = Vector3.zero;

	void Start () {
		m_Transform = gameObject.GetComponent<Transform>();
		player_Transform = GameObject.Find("Necromancer").GetComponent<Transform>();
		offset = new Vector3(-0.501f,5.423f,-2.868f);
		// temp.y = offset.y;
	}
	
	// Update is called once per frame
	void Update () {
		CamFollow();
	}
	private void CamFollow()
	{
		// temp.x = Mathf.Lerp(m_Transform.position.x,player_Transform.position.x + offset.x,Time.deltaTime*speed);
		// temp.z = Mathf.Lerp(m_Transform.position.z,player_Transform.position.z + offset.z,Time.deltaTime*speed);
		

		// m_Transform.position = temp;
		

		// easy type
		m_Transform.position = Vector3.Lerp(m_Transform.position,player_Transform.position+offset,Time.deltaTime * speed);
	}
}
