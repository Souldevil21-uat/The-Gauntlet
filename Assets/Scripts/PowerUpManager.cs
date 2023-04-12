using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public HealthPickUp Powerup;

    public void OnTriggerEnter(Collider other)
    {
        PowerUpManager powerupManager = other.GetComponent<PowerUpManager>();

        if(powerupManager != null)
        {
            powerupManager.Add(Powerup);

            Debug.Log("Im Working!");

            Destroy(gameObject);

        }

        //variable to store powerupcontroller

    }
        // Use this for initialization
        void Start()
        {

          

        }

        // Update is called once per frame
        void Update()
        {

        }


    public void Add(PowerUp powerupToAdd)
    {

        //TODO: Create The Add Method

    }

    public void Remove(PowerUp powerupToRemove)
    {

        //TODO: Create the remove method

    }
}
