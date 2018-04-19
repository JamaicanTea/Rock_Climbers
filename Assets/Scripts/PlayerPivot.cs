using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPivot : MonoBehaviour {
	public Transform player;
	public Transform player2;
	public bool movingLeft = false;
	public bool movingRight = false;
	public int life = 3;
	public float score = 0f;
	public Text scoreCount;
	public Text lifeCount;

	// Use this for initialization
	void Start () 
	{
		scoreCount.text = "Score =" + score;
		lifeCount.text = "Lives :" + life;
	}
	
	// Update is called once per frame
	void Update()
	{
		score += Time.deltaTime;
		UpdateScore ();
	}

	void UpdateScore()
	{
		scoreCount.text = "Score =" + score.ToString ("####");
	}

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
