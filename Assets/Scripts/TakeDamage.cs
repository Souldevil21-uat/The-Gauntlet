using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour {

	public float damageDone;
	public EnemyTankController owner;

    public void OnTriggerEnter(Collider other)
    {
        // Get the Health component from the Game Object that has the Collider that we are overlapping
        TankHealth otherHealth = other.gameObject.GetComponent<TankHealth>();
        // Only damage if it has a Health component
        if (otherHealth != null)
        {
            // Do damage
            otherHealth.TakeDamage(damageDone, owner);
        }

        // Destroy ourselves, whether we did damage or not
        Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
