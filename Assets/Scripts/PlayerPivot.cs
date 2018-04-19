using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPivot : MonoBehaviour {
	public Transform player;
	public Transform player2;
	public int life = 3;
	public float score = 0f;
	public Text scoreCount;
	public Text lifeCount;
	public GameObject retry;
	public GameObject returnToMenu;
	public GameObject gameOver;
	public bool movingLeft = false;
	public bool movingRight = false;
	Coroutine invuln;
	public CapsuleCollider colly;

	// Use this for initialization
	void Awake()
	{
		Time.timeScale = 1;
	}
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

		if (life <= 0) 
		{
			GameOver ();
		}
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.CompareTag("Hazard"))
			{
			life--;
			UpdateLife ();
			invuln = StartCoroutine (Invulnerability());
			}
	}

	void UpdateScore()
	{
		scoreCount.text = "Score =" + score.ToString ("####");
	}
	void UpdateLife()
	{
		lifeCount.text = "Lives :" + life;
	}

	void GameOver()
	{
		Time.timeScale = 0;
		gameOver.gameObject.SetActive (true);
		retry.gameObject.SetActive (true);
		returnToMenu.gameObject.SetActive (true);
	}
		
	void FixedUpdate () 
	{
		if (Input.GetKey (KeyCode.Mouse0)) 
		{
			movingLeft = true;
			transform.RotateAround (player.position, Vector3.forward, 100 * Time.deltaTime);
		} 
		else if (Input.GetKeyUp (KeyCode.Mouse0))
		{
			movingLeft = false;
		}
		if (Input.GetKey (KeyCode.Mouse1)) 
		{
			movingRight = true;
			transform.RotateAround (player2.position, Vector3.forward, -100 * Time.deltaTime);
		}	
		else if (Input.GetKeyUp (KeyCode.Mouse1))
		{
			movingRight = false;
		}
			
	}
	IEnumerator Invulnerability ()
	{
		colly.enabled = false;
		print ("ow!");
		yield return new WaitForSeconds (1.5f);
		print ("k im fine!");
		colly.enabled = true;
	}
}
