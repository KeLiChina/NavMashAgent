using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManager : MonoBehaviour {
	public static HouseManager instance;
	private Transform wall_1_Transform;
	private Transform wall_2_Transform;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if(instance != this)
			Destroy(gameObject);
	}
	void Start () {
		wall_1_Transform = GameObject.Find("ENV/Wall_1").GetComponent<Transform>();
		wall_2_Transform = GameObject.Find("ENV/Wall_2").GetComponent<Transform>();
	}
	
	
	void Update () {
		if(Input.GetKeyDown(KeyCode.A))
		{
			StartCoroutine(WallOpen(wall_1_Transform));
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			StartCoroutine(WallOpen(wall_2_Transform));
		}
		
	}
	IEnumerator WallOpen(Transform wall)
	{
		Vector3 temp = wall.position;
		while(wall.position.y > -2.1f)
		{
			temp.y -= 0.1f;
			wall.position = temp;
			yield return new WaitForSeconds(0.05f);
		}
		// yield return new WaitForSeconds(1f);
	}
	public void WallOpenOne()
	{
		StartCoroutine(WallOpen(wall_1_Transform));
	}
	public void WallOpenTwe()
	{
		StartCoroutine(WallOpen(wall_2_Transform));
	}
	
}
