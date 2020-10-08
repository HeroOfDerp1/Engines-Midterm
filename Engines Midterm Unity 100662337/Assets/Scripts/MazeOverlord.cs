using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

//Kaylyn McCune - 100662337
//The script that controls global aspects of the maze including:
//-death plane
//-respawn and checkpoints
//-dll manager

public class MazeOverlord : MonoBehaviour
{
    //create game object variable for player
    public GameObject player;
    //create a game object for the checkpoints
    public GameObject currentCheckpoint, tempCheckpoint;


    //DLL THINGS
    const string DLL_NAME = "Engines Midterm C++ Project";

    //METHODS
    [DllImport(DLL_NAME)]
    private static extern void ResetLogger();

    //SETTERS
    [DllImport(DLL_NAME)]
    private static extern void SaveCheckpointTime(float RTBC);

    //GETTERS
    [DllImport(DLL_NAME)]
    private static extern float GetTotalTime();

    [DllImport(DLL_NAME)]
    private static extern float GetCheckPointTime(int index);

    [DllImport(DLL_NAME)]
    private static extern int GetNumCheckpoint();

    //A bunch more wrapper functions :/
    public void SaveTime(float checkpointTime)
    {
        SaveCheckpointTime(checkpointTime);
    }

    public float LoadTime(int index)
    {
        //error check to see if index is outside valid range
        if (index >= GetNumCheckpoint())
        {
            return -1.0f;
        }
        else
        {
            return GetCheckPointTime(index);
        }
    }

    public float LoadTotalTime()
    {
        return GetTotalTime();
    }

    public void ResetLoggerTest()
    {
        ResetLogger();
    }

    //declare my time variable
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        //initiate the variable
        //joining a cult now ig
        timer = 0.0f;
        tempCheckpoint = currentCheckpoint;
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

        //DLL Timer
        timer += Time.deltaTime;

        //check to see if the checkpoint has changes
        if(tempCheckpoint.transform.position != currentCheckpoint.transform.position)
        {
            //checkpoint has changed
            //update temp checkpoint
            tempCheckpoint = currentCheckpoint;
            //send the time to the dll logger
            SaveTime(timer);
            //reset the timer
            timer = 0.0f;
        }
    }
}
