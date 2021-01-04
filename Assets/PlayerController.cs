using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
	float horizontalInput, verticleInput;
	public float moveSpeed;
	bool fire;
	float projectileSpeed = 20f;
	float horizontalLimit = 10, verticalLimit = 10;
	public Pool bulletPool;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		verticleInput = Input.GetAxis("Vertical");
		fire = Input.GetButtonDown("Jump");
		transform.Translate(transform.right*horizontalInput*moveSpeed);
		transform.Translate(transform.forward*verticleInput*moveSpeed);
		if(Mathf.Abs(transform.position.x) > horizontalLimit)
		{
			transform.position = new Vector3(horizontalLimit*Mathf.Sign(transform.position.x), transform.position.y, transform.position.z);
		}
		if(fire)
		{
			Fire();
		}
        
	}
    
	void Fire()
	{
		GameObject bullet  = bulletPool.GetOne();
		bullet.transform.position = transform.position + transform.forward*2;
		Rigidbody rb = bullet.GetComponent<Rigidbody>();
		rb.velocity = transform.forward * projectileSpeed;
		
		bullet.SetActive(true);
	}
}
