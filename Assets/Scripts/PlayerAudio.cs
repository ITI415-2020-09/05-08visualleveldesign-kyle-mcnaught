using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{

	public AudioClip coinSound;
	
	public AudioSource audioC;
	
    private void OnTriggerEnter(Collider other)
   {
   		if(other.gameObject.CompareTag("Pickup"))
   		{
      		audioC.PlayOneShot(coinSound);
      	}
    }
}
