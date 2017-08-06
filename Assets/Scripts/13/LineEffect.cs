using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineEffect : MonoBehaviour {
	private LineRenderer m_LineRenderer;
	private float speed = 0.5f;
	private Material m_Material;
	
	void Start () {
		m_LineRenderer = gameObject.GetComponent<LineRenderer>();
		m_Material = m_LineRenderer.material;
	}
	
	
	void Update () {
		SetXSpeed(speed);
	}
	private void SetXSpeed(float f)
	{
		float x = Time.time * f;
		m_Material.SetTextureOffset("_MainTex",new Vector2(x,0));
	}
}
