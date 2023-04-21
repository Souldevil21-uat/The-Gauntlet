using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : PickUp 
{
    public HealthPowerUp powerUp;


    public void OnTriggerEnter(Collider other)
    {

        PowerUpManager powerupManager = other.GetComponent<PowerUpManager>();

        if (powerupManager != null)
        {
            powerupManager.Add(powerUp);

            Debug.Log("Im Working!");

            Destroy(gameObject);

        }
    }



}
