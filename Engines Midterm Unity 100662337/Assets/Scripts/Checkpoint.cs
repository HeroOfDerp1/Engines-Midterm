using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Kaylyn McCune - 100662337
//Checks for checkpoint collision and passes that checkpoint to the maze overlord

public class Checkpoint : MonoBehaviour
{
    //create a maze overlord to pass the checkpoint to
    public MazeOverlord mazeOverlord;
    //create a collider variable to turn the trigger point off, so checkpoint cant be triggered more than once
    public Collider m_collider;

    // Start is called before the first frame update
    void Start()
    {
        //get the collider
        m_collider = GetComponent<Collider>();
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
            //destroy the collider so it can never be triggered again :)
            Destroy(m_collider);

        }
    }
}
