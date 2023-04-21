using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour {

    public float Health = 100;
    public float curHealth = 100;
   


    // Use this for initialization
    void Start () 
    {

        curHealth = Health;
		
	}

    public void Die(EnemyTankController source) 
    {
    
        Destroy(gameObject);
    
    }

    public void TakeDamage(float amount, EnemyTankController source)
    {
        curHealth = curHealth - amount;
        Debug.Log(source.name + " did " + amount + " damage to " + gameObject.name);
        curHealth = Mathf.Clamp(curHealth, 0, Health);

        if (curHealth <= 0)
        {
            Die(source);
        }
    }

    public void Heal(float amount, PlayerController source)
    {

        curHealth += amount;

    }



    // Update is called once per frame
    void Update () {

        if (curHealth <1)
        {

            Destroy(gameObject);

        }

		
	}

     void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Bullet"))
        {
            curHealth -= 20;

        }

    }
       
    
}
