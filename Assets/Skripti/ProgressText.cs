using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressText : MonoBehaviour
{

	public GameObject MainObject;

	private Objekti counter;
	void Start () {
		counter= MainObject.GetComponent<Objekti>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetComponent<Text>().text = counter.GetCorrectCarCount() + "/" + counter.TotalCarCount;
	}
}
