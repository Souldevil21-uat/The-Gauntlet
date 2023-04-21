using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class SpeedPickUp : PickUp {

    public SpeedPowerUp speedUp;

    public void OnTriggerEnter(Collider other)
    {

        PowerUpManager powerupManager = other.GetComponent<PowerUpManager>();

        if (powerupManager != null)
        {
            powerupManager.Add(speedUp);

            Debug.Log("Im Working!");

            Destroy(gameObject);

        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
