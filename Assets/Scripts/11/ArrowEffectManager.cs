using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowEffectManager : MonoBehaviour {

	private Transform m_Transform;
	private ParticleSystem[] m_ParticleSystems;
	void Awake () 
	{
		m_Transform = gameObject.GetComponent<Transform>();
		m_ParticleSystems = gameObject.GetComponentsInChildren<ParticleSystem>();
		// PlayEffect();
	}
	
	
	public void PlayEffect()
	{
		for (int i = 0 ; i < m_ParticleSystems.Length ; i ++)
		{
			m_ParticleSystems[i].Play();
		}
	}
}
