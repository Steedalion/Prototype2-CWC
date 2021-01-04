using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public Transform oneEnd, otherEnd;
	public Pool spawnPool;
	WaitForSeconds wait;
	Coroutine spawning;
    // Start is called before the first frame update
    void Start()
    {
	    wait = new WaitForSeconds(1);
	    spawning= StartCoroutine(Spawn());
    }



    // Update is called once per frame
    void Update()
    {
        
    }
    
	IEnumerator Spawn()
	{
		while(true){
			GameObject animal = spawnPool.GetOne();
			if(animal == null){yield return wait;}
		
			animal.transform.position = Vector3.Lerp(oneEnd.position, otherEnd.position, Random.Range(0f,1f));
			animal.transform.rotation = Quaternion.EulerRotation(0,3.14f,0);
			animal.SetActive(true);
			yield return wait;
		}
	}
	// This function is called when the behaviour becomes disabled () or inactive.
	protected void OnDisable()
	{
		StopCoroutine(spawning);
	}
}
