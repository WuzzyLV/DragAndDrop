using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	
	[HideInInspector] 
	public Vector2 lastPos;

	public Canvas kanva;
	
	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;


	void Start() {
		
	}
}
