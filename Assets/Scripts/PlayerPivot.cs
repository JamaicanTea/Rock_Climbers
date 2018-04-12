using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPivot : MonoBehaviour {
	public Transform player;
	public Transform player2;
	public bool movingLeft = false;
	public bool movingRight = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetKey (KeyCode.Mouse0)) 
		{
			transform.RotateAround(player.position, Vector3.forward, 100 * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.Mouse1)) 
		{
			transform.RotateAround (player2.position, Vector3.forward, -100 * Time.deltaTime);
		}	
	}
}
