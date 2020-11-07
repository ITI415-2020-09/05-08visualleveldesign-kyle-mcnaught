using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerAudio : MonoBehaviour
{

	public AudioClip coinSound;
	
	public AudioSource audioC;
	
	public AudioMixerSnapshot earlygameSnapshot;
	public AudioMixerSnapshot lategameSnapshot;
	
	
    private void OnTriggerEnter(Collider other)
   {
   		if(other.gameObject.CompareTag("Pickup"))
   		{
      		audioC.PlayOneShot(coinSound);
      	}
      	
      	if(other.gameObject.CompareTag("Zone"))
   		{
      		lategameSnapshot.TransitionTo(0.5f);
      	}
      	
    }
    
    private void OnTriggerExit(Collider other)
    {
    	if(other.gameObject.CompareTag("Zone"))
   		{
      		earlygameSnapshot.TransitionTo(0.5f);
      	}
    }
    
}
