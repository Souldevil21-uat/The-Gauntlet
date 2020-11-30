using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

    public float Speed = 600.0f;
    public int damage = 50;


    void Update()
    {
        transform.position +=
        transform.forward * Speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider collision)
    {
        print ("I Hit Something!");
        Destroy(gameObject);
    }
}