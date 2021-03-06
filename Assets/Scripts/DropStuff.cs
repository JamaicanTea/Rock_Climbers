﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropStuff : MonoBehaviour {
	public GameObject projectile;
	public GameObject dropPanel;
	public float projSpeed = 20f;
	public float shootTime =0f;
	public float shootDelay =0f;

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("Shoot", shootTime, shootDelay);
	}
	
	// Update is called once per frame
	void Shoot () 
	{
		GameObject projPrefab = Instantiate (projectile, dropPanel.transform.position, transform.rotation);
		Rigidbody rb = projPrefab.GetComponent<Rigidbody> ();
		Vector3 randomPos = new Vector3 (Random.Range(-18.6f, 120f), transform.position.y,transform.position.z);
		projPrefab.transform.position = randomPos;
		rb.velocity = Vector3.back * projSpeed;	
	}
}
