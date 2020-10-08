using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Kaylyn McCune - 100662337
//The script that controls global aspects of the maze including:
//-death plane
//-respawn and checkpoints

public class MazeOverlord : MonoBehaviour
{
    //create game object variable for player
    public GameObject player;
    //create a game object for the checkpoints
    public GameObject currentCheckpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //gets the players current position
        Vector3 temp = player.transform.position;
        //compares the current y position to that of the death plane to see if the player has fallen
        if (temp.y <= -3)
        {
            //the player has fallen, respawn them at the current checkpoint
            player.transform.position = currentCheckpoint.transform.position;
        }

    }
}
