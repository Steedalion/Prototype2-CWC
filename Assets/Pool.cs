using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
	public GameObject[] prefabs;
	private GameObject[] pool;
	public int size = 10;
	
    // Start is called before the first frame update
	void Awake()
	{
		pool = new GameObject[size];
		GameObject prefabtype;
		GameObject prefab;
		int prefsize = prefabs.Length; 
		for (int i = 0; i < size; i++) {
			prefabtype = prefabs[i%prefsize];
			prefab = Instantiate(prefabtype);
			prefab.SetActive(false);
			pool[i]=prefab;
		}
        
	}
	public GameObject GetOne()
	{
		for (int i = 0; i < size; i++) {
			if(!pool[i].active)
			{
				return pool[i];
			}
		}
		return null;
		
	}
}
