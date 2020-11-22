using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankData : MonoBehaviour
{
    //Components
    public TankMover mover;
    public TankShooter shooter;
    public TankHealth health;

    //Data
    public float moveSpeed;
    public float rotateSpeed;
    public float fireRate;

    // Use this for initialization
    void Start()
    {

        mover = GetComponent<TankMover>();
        shooter = GetComponent<TankShooter>();
        health = GetComponent<TankHealth>();

    }

}
	