using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Kaylyn McCune - 100662337
//Checks for checkpoint collision and passes that checkpoint to the maze overlord

public class Checkpoint : MonoBehaviour
{
    //create a maze overlord to pass the checkpoint to
    public MazeOverlord mazeOverlord;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //check for collision and passes the checkpoint in as the current active checkpoint
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "player")
        {
            mazeOverlord.currentCheckpoint = gameObject;
        }
    }
}
