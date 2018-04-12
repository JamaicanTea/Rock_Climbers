using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeSpawner : MonoBehaviour {
	public GameObject grabLedge;
	public GameObject trapLedge;
	Vector3[] pos;
	public int ledgeOnGrid = 400;
	public int trapLedgeOnGrid = 60;
	public int gridWidth = 40;
	public int gridHeight= 60;

	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < gridWidth;i++) 
		{
			GameObject ledge1 = Instantiate (grabLedge,new Vector3(i *2.5f,0,0), grabLedge.transform.rotation) as GameObject;
			for (int j = 0; j < gridHeight;j++) 
			{
				GameObject ledge2 = Instantiate (grabLedge,new Vector3(i*2.5f,j *2.5f,0), grabLedge.transform.rotation) as GameObject;

			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
