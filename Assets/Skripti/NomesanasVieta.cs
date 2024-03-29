﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, IDropHandler{
	public AudioClip successSoundEffect;
	public GameObject correctCar;
	
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmStarpiba, yIzmStarpiba;
	public Objekti objektuSkripts;

    public void OnDrop(PointerEventData eventData)
    {
	    if (eventData.pointerDrag != null)
		{
			if (eventData.pointerDrag.tag.Equals(tag))
			{
				vietasZRot =
				eventData.pointerDrag.
				GetComponent<RectTransform>().transform.eulerAngles.z;

				velkObjZRot =
				GetComponent<RectTransform>().transform.eulerAngles.z;

				rotacijasStarpiba =
				Mathf.Abs(vietasZRot - velkObjZRot);
				
				vietasIzm =
				eventData.pointerDrag.
				GetComponent<RectTransform>().localScale;

				velkObjIzm =
					GetComponent<RectTransform>().localScale;

				xIzmStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
				yIzmStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);

				Debug.Log("Objektu rotācijas starpība: " + rotacijasStarpiba
					+ "\nPlatuma starpība: " + xIzmStarpiba +
					"\nAugstuma starpība: " + yIzmStarpiba);


				if ((rotacijasStarpiba <= 6 ||
					(rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
					&& (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1))
				{
					Debug.Log("Nomests pareizajā vietā!");
                    objektuSkripts.vaiIstajaVieta = true;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition
						= GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation =
						GetComponent<RectTransform>().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform>().localScale =
						GetComponent<RectTransform>().localScale;

					//Paziņo Objekti.cs, ka mašīna ir nomesta pareizajā vietā
					objektuSkripts.addCorrectCar();
					//Atskaņo savu skaņas effektu cauri statiskajam SoundManager
					SoundManager.SM.PlaySoundEffect(successSoundEffect);
				}

				//Ja tagi nesakrīt, tātad nepareizajā vietā
			} else	{
				objektuSkripts.vaiIstajaVieta = false;
				SoundManager.SM.PlayFailSoundEffect();
				//iestata vilkto objektu jeb mašīnu uz pēdējo pozīciju
				eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = objektuSkripts.lastPos;
            }
		}
		
	}
}
