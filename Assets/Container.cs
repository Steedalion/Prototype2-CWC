using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
	public string tag;
    
	// OnTriggerExit is called when the Collider other has stopped touching the trigger.
	protected void OnTriggerExit(Collider other)
	{
		//Debug.Log("Exited");
		if(other.CompareTag(tag))
		{
			other.gameObject.SetActive(false);
		}
	}
    
}
