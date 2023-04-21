using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

	private Room[,] grid;
    public GameObject[] gridPrefabs;
    public int rows;
    public int cols;
    public float roomWidth = 50.0f;
    public float roomHeight = 50.0f;
    public int mapSeed;
    public bool isMapOfTheDay;
    public GameObject RandomRoomPrefab()
    {
        return gridPrefabs[UnityEngine.Random.Range(0, gridPrefabs.Length)];
    }

    public int DateToInt(DateTime dateToUse)
    {
        // Add our date up and return it
        return dateToUse.Year + dateToUse.Month + dateToUse.Day + dateToUse.Hour + dateToUse.Minute + dateToUse.Second + dateToUse.Millisecond;
    }

    public void GenerateGrid() 
    {

 // Type or member is obsolete
        UnityEngine.Random.seed = mapSeed;
        UnityEngine.Random.seed = DateToInt(DateTime.Now);


    }

    public void GenerateMap()
    {
        // Clear out the grid - "column" is our X, "row" is our Y
        grid = new Room[cols, rows];

        // For each grid row...
        for (int currentRow = 0; currentRow < rows; currentRow++)
        {
            // for each column in that row
            for (int currentCol = 0; currentCol < cols; currentCol++)
            {
                // Figure out the location. 
                float xPosition = roomWidth * currentCol;
                float zPosition = roomHeight * currentRow;
                Vector3 newPosition = new Vector3(xPosition, 0.0f, zPosition);

                // Create a new grid at the appropriate location
                GameObject tempRoomObj = Instantiate(RandomRoomPrefab(), newPosition, Quaternion.identity) as GameObject;

                // Set its parent
                tempRoomObj.transform.parent = this.transform;

                // Give it a meaningful name
                tempRoomObj.name = "Room_" + currentCol + "," + currentRow;

                // Get the room object
                Room tempRoom = tempRoomObj.GetComponent<Room>();

                // Save it to the grid array
                grid[currentCol, currentRow] = tempRoom;
                if (currentRow == 0)
                {
                    tempRoom.doorNorth.SetActive(false);
                }
                else if (currentRow == rows - 1)
                {
                    // Otherwise, if we are on the top row, open the south door
                    Destroy(tempRoom.doorSouth);
                }
                else
                {
                    // Otherwise, we are in the middle, so open both doors
                    Destroy(tempRoom.doorNorth);
                    Destroy(tempRoom.doorSouth);
                }
                if(currentCol== 0) 
                {
                tempRoom.doorEast.SetActive(false);
                }

                else if (currentCol== rows - 1) 
                {
                
                Destroy (tempRoom.doorWest);
                
                }

                else 
                {
                
                Destroy(tempRoom.doorEast); 
                Destroy(tempRoom.doorWest);
                
                }

            }

        }


    }



    // Use this for initialization
    void Start () {
        if (isMapOfTheDay)
        {
            mapSeed = DateToInt(DateTime.Now.Date);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
