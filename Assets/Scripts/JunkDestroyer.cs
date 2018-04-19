using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDestroyer : MonoBehaviour {
	public float maxY = -37.8f;
	public GameObject junk;
	// Update is called once per frame
	void Update () 
	{
		if (junk.transform.position.y < maxY) 
		{
			Destroy (this.gameObject);
		}
	}
}
