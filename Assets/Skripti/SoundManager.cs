using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	[HideInInspector]
	public static SoundManager SM;
	[HideInInspector]
	public AudioSource audioSource;

	public AudioClip failSoundEffect;
	void Awake()
	{
		if(SM != null)
			GameObject.Destroy(SM);
		else
			SM = this;
         
		DontDestroyOnLoad(this);
		
		audioSource = GetComponent<AudioSource>();
		
		
	}

	//Tā kā nepareizais skaņas efekts visām mašīnām ir vienāds tas ir ielikts statiski pieejama funkcijā
	public void PlayFailSoundEffect()
	{
		audioSource.PlayOneShot(failSoundEffect);
	}

	public void PlaySoundEffect(AudioClip clip)
	{
		audioSource.PlayOneShot(clip);
	}

}
