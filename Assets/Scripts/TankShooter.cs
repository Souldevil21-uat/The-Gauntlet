using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooter : MonoBehaviour {

    // Calls our bullet
    public GameObject bullet;
    // Allows us to get the end of the tank barrel in order to generate our bullet properly
    public Transform TankBarrel;

    // lets us set our fast or slow our bullet goes
    public int bulletSpeed;
    // despawns the bullet so it doesnt stay infinitely
    public float despawnTime = 3.0f;

    public bool shoot = true;
    // lets us set how long it takes to shoot the next bullet
    public float shootTimer = 0.25f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // if the space bar is pressed, the next part of the code starts
        if (Input.GetKey(KeyCode.Space))
        {
            // makes it so we dont spam space bar and continuiously shoot bullets
            if (shoot)
            {

                shoot = false;
                Shoot();
                StartCoroutine(ShootingYield());
            }

        }
		
	}

    // pauses our shooting so we can wait for the next one
    IEnumerator ShootingYield()
    {

        yield return new WaitForSeconds(shootTimer);
        shoot = true;

    }

    // shoots the bullet
    void Shoot()
    {

        var Bullet = Instantiate(bullet, TankBarrel.position, TankBarrel.rotation);
        Bullet.GetComponent<Rigidbody>().velocity = Bullet.transform.forward * bulletSpeed;

        Destroy(Bullet, despawnTime);

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);

        }
    }

}
