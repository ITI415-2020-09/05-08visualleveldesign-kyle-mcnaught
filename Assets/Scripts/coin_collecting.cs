using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coin_collecting : MonoBehaviour
{
	public TextMeshProUGUI countText;
	public GameObject winTextObject;
	
	private int count;
	
	void Start()
    {
		count = 0;
        
        SetCountText();
        winTextObject.SetActive(false);
    }
    
    void SetCountText ()
   {
   	countText.text = "Score: " + count.ToString();
   	}
   
    
    private void OnTriggerEnter(Collider other)
   {
   		if(other.gameObject.CompareTag("Pickup"))
   		{
      		other.gameObject.SetActive(false);
      		count = count + 1;
      	
      	 SetCountText();
      	}
      	 if(other.gameObject.CompareTag("Finish"))
   		{
      	Destroy( this.gameObject );
      	winTextObject.SetActive(true);
   		}
    }
}
