using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {

	//Katru reizi kad pacel mašīnu tā pozīcija tiek saglabāta šajā mainīgajā
	//gadijumā ja to ieliek nepareizejā vietā, lai nebutu vajadziba saglabat katras mašīnas sākuma pozīciju
	[HideInInspector] 
	public Vector2 lastPos;

	public Canvas kanva;

	//uzvaras paneļa instance lai to var paradit kad spele beidzas
	public GameObject WinPanel;

	//Cik masinas ir jasaliek lai spele beigtos
	public int TotalCarCount;
	
	[HideInInspector]
	public bool vaiIstajaVieta = false;

	[HideInInspector]
	public GameObject pedejaisVilktais = null;

	int correctCarCount = 0;
	
	public void addCorrectCar()
	{
		correctCarCount++;
		if(correctCarCount == TotalCarCount)
		{
			Debug.Log("Spele beigusies");
			WinPanel.SetActive(true);
			Timer.Instance.TogglePause();
		}
	}
	
	public int GetCorrectCarCount()
	{
		return correctCarCount;
	}
	
}
