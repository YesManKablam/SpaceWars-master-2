using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	
	void Update () 
	{
		if (Input.GetKey ("e")) 
		{
			Time.timeScale = .5f;							// Slows world time down to half speed when the "e" key is held
 			audio.pitch = Time.timeScale = 0.5f;			// Pitch drops the audio 
		} 
		else 
		{
			Time.timeScale = 1f;							// When key is release, time returns to normal
			audio.pitch = Time.timeScale = 1f;
		}
	}
}
