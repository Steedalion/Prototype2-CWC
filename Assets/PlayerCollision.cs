using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	// OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider.
	protected void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.other.CompareTag("Animal"))
		{
			Debug.Log("Game Over");
		}
	}

}
