using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickup : MonoBehaviour {

	public GameObject pickupPrefab;
	private GameObject spawnedPickup;
	public float spawnDelay;
	private float nextSpawnTime;
	private Transform tf;

	// Use this for initialization
	void Start () 
	{

		nextSpawnTime = Time.time + spawnDelay;

	}
	
	// Update is called once per frame
	void Update () 
	{
        if (spawnedPickup == null) 
		{
			if (Time.time > nextSpawnTime)
			{

				Instantiate(pickupPrefab, transform.position, Quaternion.identity);
				nextSpawnTime = Time.time + spawnDelay;

			}

		}

		else

		{

			nextSpawnTime = Time.time + spawnDelay;

		}

		
	}



        //variable to store powerupcontroller

}
