using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLabel : MonoBehaviour {

	public bool HideOnPause = false;
	// Use this for initialization
	Timer timer;
	Text textComponent;
	void Start ()
	{
		timer = Timer.Instance;
		textComponent = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		textComponent.text = timer.ToString();
		
		if (HideOnPause)
		{
			if (timer.isPaused())
			{
				textComponent.enabled = false;
			}else
			{
				textComponent.enabled = true;
			}

		}
	}
}
