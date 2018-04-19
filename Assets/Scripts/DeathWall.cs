using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWall : MonoBehaviour {
	public GameObject retry;
	public GameObject returnToMenu;
	public GameObject gameOver;

	void OnTriggerEnter (Collider col)
	{
		if (col.CompareTag ("Player")) 
		{
			Time.timeScale = 0;
			retry.gameObject.SetActive (true);
			returnToMenu.gameObject.SetActive (true);
			gameOver.gameObject.SetActive (true);
		}

	}
}
