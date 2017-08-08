using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGuide : MonoBehaviour {
	public GameObject prefab_LineEffect;
	public GameObject prefab_TargetEffect;
	private Transform m_Transform;
	private Transform point_0;
	private Transform point_1;
	private Transform point_2;
	private GameObject targetEffect;
	private GameObject lineEffect;
	void Start () {
		m_Transform = gameObject.GetComponent<Transform>();
		point_0 = m_Transform.FindChild("Point_0").GetComponent<Transform>();
		point_1 = m_Transform.FindChild("Point_1").GetComponent<Transform>();
		point_2 = m_Transform.FindChild("Point_2").GetComponent<Transform>();
		 CreateEffect(point_0.position,point_1.position);
		
	}
	
	
	void Update () {
		
	}
	private void CreateEffect(Vector3 point1,Vector3 point2)
	{
		targetEffect = Instantiate(prefab_TargetEffect,point2,Quaternion.identity);
		lineEffect = Instantiate(prefab_LineEffect,point2,Quaternion.identity);
		lineEffect.GetComponent<LineRenderer>().SetPosition(0,point1);
		lineEffect.GetComponent<LineRenderer>().SetPosition(1,point2);


	}
	public void TriggerEnter(object id)
	{
		int index = (int)id;
		if(index ==1)
		{
			GameObject.Destroy(targetEffect);
			GameObject.Destroy(lineEffect);
			CreateEffect(point_1.position,point_2.position);
		}
		if(index == 2)
		{
			GameObject.Destroy(targetEffect);
			GameObject.Destroy(lineEffect);
			HouseManager.instance.WallOpenOne();
			// CreateEffect(point_1.position,point_2.position);
		}
	}
}
