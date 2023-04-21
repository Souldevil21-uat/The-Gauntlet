using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{

    public bool isPermanent;
    private List<PowerUp> removedPowerupQueue;
    public List<PowerUp> powerups;

    public void DecrementPowerupTimers()
    {
        // One-at-a-time, put each object in "powerups" into the variable "powerup" and do the loop body on it
        foreach (PowerUp powerup in powerups)
        {
            // Subtract the time it took to draw the frame from the duration
            powerup.duration -= Time.deltaTime;
            // If time is up, we want to remove this powerup
            if (powerup.duration <= 0)
            {
                Remove(powerup);
            }
        }
    }

    private void ApplyRemovePowerupsQueue()
    {
        // Now that we are sure we are not iterating through "powerups", remove the powerups that are in our temporary list
        foreach (PowerUp powerup in removedPowerupQueue)
        {
            powerups.Remove(powerup);
        }
        // And reset our temporary list
        removedPowerupQueue.Clear();
    }


    // Use this for initialization
    void Start()
        {

        powerups = new List<PowerUp>();
        removedPowerupQueue = new List<PowerUp>();

          

        }

        // Update is called once per frame
        void Update()
        {

        DecrementPowerupTimers();

        }
    private void LateUpdate()
    {
        ApplyRemovePowerupsQueue();
    }



    public void Add(PowerUp powerupToAdd)
    {

        powerupToAdd.Apply(this);
        // Save it to the list
        powerups.Add(powerupToAdd);

    }

    public void Remove(PowerUp powerupToRemove)
    {

        powerupToRemove.Remove(this);
        removedPowerupQueue.Remove(powerupToRemove);

    }


}
