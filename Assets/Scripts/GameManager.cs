using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    public List<PlayerController> players;
    public List<AIController> enemy;

    //Awake happens when the object is called
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }

        else
        {
            Destroy(gameObject);

        }

        // creates a list of player controllers.
        players = new List<PlayerController>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
