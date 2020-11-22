using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : MonoBehaviour {

    
    public TankData Data;
    public CharacterController cc;
	// Use this for initialization
	void Start () {

        Data = GetComponent<TankData>();
        cc = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void Move (Vector3 directionToMove)
    {
        //Process Movement
        // Start Rotation
        transform.Rotate(0, directionToMove.x * Data.rotateSpeed * Time.deltaTime, 0);

        // Start Movement
        Vector3 moveVector = Vector3.zero;
        moveVector.z = directionToMove.z * Data.moveSpeed;
        moveVector = transform.TransformDirection(moveVector);
        cc.SimpleMove(moveVector);

    }
}
