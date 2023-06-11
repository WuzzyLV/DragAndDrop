using UnityEngine;

public class SoundManager : MonoBehaviour {
	
	public static SoundManager SM;
	[HideInInspector]
	public AudioSource audioSource;

	public AudioClip failSoundEffect;
	public AudioClip clickSoundEffect;
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
	
	public void PlayClickSoundEffect()
	{
		audioSource.PlayOneShot(clickSoundEffect);
	}

	public void PlaySoundEffect(AudioClip clip)
	{
		audioSource.PlayOneShot(clip);
	}

}
