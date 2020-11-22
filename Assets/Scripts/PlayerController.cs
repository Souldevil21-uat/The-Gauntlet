using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller {

    public TankData pawn;

	// Use this for initialization
	public override void Start () {

		
	}
	
	// Update is called once per frame
	public override void Update () {

        // Handle Moving

        // Make Movement 0
        Vector3 directionToMove = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            directionToMove.z = 1;

        }

        else if (Input.GetKey(KeyCode.S))
        {

            directionToMove.z = -1;

        }

        if (Input.GetKey(KeyCode.D))
        {

            directionToMove.x = 1;

        }

        else if (Input.GetKey(KeyCode.A))
        {

            directionToMove.x = -1;

        }

        // Start movement
        pawn.mover.Move(directionToMove);

    }
}
