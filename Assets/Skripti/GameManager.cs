using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GoGameScene()
	{
		SceneManager.LoadScene("PilsetasKarte");
	}
	
	public void GoMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
	
	public void RestartGame()
	{
		Application.LoadLevel(Application.loadedLevel);
	}
	
	public void ExitGame()
	{
		Application.Quit();
	}
}
