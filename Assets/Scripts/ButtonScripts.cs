using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour {

	// Use this for initialization
	public void PlayOrReset () 
	{
		SceneManager.LoadScene ("Game Scene");
	}
	
	// Update is called once per frame
	public void Quit () 
	{
		Application.Quit();	
	}

	public void MainMenu()
	{
		SceneManager.LoadScene ("TitleScreen");
	}
}
