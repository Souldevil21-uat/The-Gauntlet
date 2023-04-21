using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class HealthPowerUp : PowerUp {

    public float healthToAdd;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Apply(PowerUpManager target) 
	{
        // Apply Health changes
        TankHealth targetHealth = target.GetComponent<TankHealth>();
        if (targetHealth != null)
        {
            // The second parameter is the pawn who caused the healing - in this case, they healed themselves
            targetHealth.Heal(healthToAdd, target.GetComponent<PlayerController>());
        }

    }
    public override void Remove(PowerUpManager target) 
	{
	
	
	
	}
}
