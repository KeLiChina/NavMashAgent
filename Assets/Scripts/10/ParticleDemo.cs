using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDemo : MonoBehaviour {

	private ParticleSystem m_ParticleSystem;
	void Start () 
	{
		m_ParticleSystem = gameObject.GetComponent<ParticleSystem>();
	}
	
	void Update () {
		ParticleCtrl();
	}
	private void ParticleCtrl()
	{
		if(Input.GetKeyDown(KeyCode.A))
		{
			m_ParticleSystem.Play();
		}
		if(Input.GetKeyDown(KeyCode.B))
		{
			m_ParticleSystem.Stop();
		}
	}
}
