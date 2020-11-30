using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSenses : MonoBehaviour {

    public float hearingModifer = 1.0f;
    public float fieldOfView = 45.0f;
    public float viewDistance = 10.0f;

    public bool CanSee (TankData otherTank)
    {
        // Handle the FOV

        // Find the vector to the other tank
        Vector3 vectorToOtherTank = otherTank.transform.position - transform.position;

        // find the angle to the other tanks
        float viewAngle = Vector3.Angle(vectorToOtherTank, transform.forward);

        // if that angle is greater then or equal to our field of view, then it is out of our vision, so we cant see it.
        if (viewAngle > fieldOfView)
        {
            return false;

        }

        // Handle Sight

        // Raycast (Calculate a line from tank to tank)
        RaycastHit hit;

        // If the first object that our ray hits is another tank, then we can see it
        if (Physics.Raycast(transform.position, vectorToOtherTank, out hit, viewDistance ))
        {
            //get the TankData of the first thing being hit
            TankData viewedObjectData = hit.collider.gameObject.GetComponent<TankData>();
            //if thats the object im looking for
            if (viewedObjectData == otherTank)
            {
                //then we saw it.
                return true;

            }

            


        }
        // otherwise, our line of sight is blocked.
        return false;

        


    }

	public bool CanHear (TankData otherTank)
    {

        // get the noisemaking ability of the other tank
        NoiseMaker otherNoise = otherTank.gameObject.GetComponent<NoiseMaker>();
        // if it doesnt exist, we cant hear it.
        if (otherNoise == null)
        {

            return false;

        }

        else
        {

            // if it does exist, check if we are closer then (volume * hearingModifer
            if(Vector3.Distance(otherTank.transform.position, transform.position) <= otherNoise.soundVolume* hearingModifer)
            {

                return true;



            }


        }

        // if i get here, and i havent heard it yet, then i cant hear it.

        return false;
    }
}
