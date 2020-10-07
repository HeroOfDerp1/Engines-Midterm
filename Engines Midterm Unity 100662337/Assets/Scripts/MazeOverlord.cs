using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Kaylyn McCune - 100662337
//The script that controls global aspects of the maze including:
//-death plane

public class MazeOverlord : MonoBehaviour
{
    //create game object variable for player
    public GameObject player;

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
            //the player has fallen, respawn them
            temp = new Vector3(15.7f, 1.64f, 23.13f);
            player.transform.position = temp;
        }
    }
}
