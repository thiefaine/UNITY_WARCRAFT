﻿using UnityEngine;
using System.Collections;

public class SpawnHuman4 : MonoBehaviour {

	private float spawningTimer = 0.0f;
	public float spawnMax = 5.0f;

	public humanManage4 omanage;
	public mainCharacter4 human;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		spawningTimer += Time.deltaTime;
		if (spawningTimer >= spawnMax)
		{
			Debug.Log("New Human unit is ready !");
			spawningTimer = 0.0f;
			mainCharacter4 newOne = Instantiate(human);
			newOne.transform.position = new Vector2(6.7f, -1.5f);
			//humanManage4.heroes.Add(newOne);
			omanage.heroes.Add(newOne);
		}
	}
}
