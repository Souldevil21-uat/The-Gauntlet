using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankHealth : MonoBehaviour {

    public int Health = 100;
    public int curHealth = 100;


    // Use this for initialization
    void Start () {
		
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
