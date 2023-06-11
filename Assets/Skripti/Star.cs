using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Star : MonoBehaviour
{
	// Pēc cik sekundēm zvaigzne pazūd
	public float TimeGoal;
	
	void Start () {
		
	}
	
	void Update () {
		if (Timer.Instance.currentTime >= TimeGoal)
		{
			GetComponent<Image>().enabled = false;
		}
	}
}
