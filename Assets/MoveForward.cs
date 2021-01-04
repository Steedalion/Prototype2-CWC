using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
	float speed;
	public float maxSpeed=50f;
    // Start is called before the first frame update
    void Start()
	{
		speed = Random.Range(2, maxSpeed);
       
    }

    // Update is called once per frame
    void Update()
	{
		transform.Translate(Vector3.forward*speed*Time.deltaTime);
        
    }
}
