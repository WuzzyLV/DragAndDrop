using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	public static Timer Instance;
	
	[HideInInspector]
	public float currentTime = 0f;
	
	bool paused = false;
	
	//Uzstaisīta statistiska refrence lai varētu piekļūt no citiem skriptiem bez manualas instances padeves jo ir vajadzigs tikai viens taimeris
	void Awake()
	{
		if(Instance != null)
			GameObject.Destroy(Instance);
		else
			Instance = this;
	}
	//Pievieno laiku timerim no cik laiks tika izsterets starp kadriem
	void Update () {
		if (paused)
			return;
		currentTime += Time.deltaTime;
	}
	//Metode lai apstadinatu taimeri.
	public void TogglePause()
	{
		paused = !paused;
	}

	public bool isPaused()
	{
		return paused;
	}
	//Metode lai ērti varētu piekļūti pie taimera lietoaja formatejuma
	public String ToString()
	{
		int minutes = (int)currentTime / 60;
		int seconds = (int)currentTime % 60;
		int milliseconds = (int)(currentTime * 100) % 100;
		
		return minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
	}
}
