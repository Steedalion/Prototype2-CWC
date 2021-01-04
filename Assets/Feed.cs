using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feed : MonoBehaviour
{
 
 // OnTriggerEnter is called when the Collider other enters the trigger.
 protected void OnTriggerEnter(Collider other)
 {
 	//Debug.Log("Triggered");
 	if(other.CompareTag("Food"))
 	{
 		gameObject.SetActive(false);
 	}
 }
 // OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
 protected void OnCollisionEnter(Collision collisionInfo)
 {
 	//Debug.Log("Collided");
 	if(collisionInfo.other.CompareTag("Food"))
 	{
 		gameObject.SetActive(false);
 	}
 }
}
