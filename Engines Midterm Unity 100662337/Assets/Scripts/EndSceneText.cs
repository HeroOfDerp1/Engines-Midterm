using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

//Kaylyn McCune - 100662337
//controls the text on the end screen
//and the button

public class EndSceneText : MonoBehaviour
{

    //declare variables
    public Text total, c1, c2, c3, c4, c5;
    //create a maze object so i can access the DLL
    public MazeOverlord overlord;
    float temp;

    // Start is called before the first frame update
    void Start()
    {
        //c1
        temp = overlord.LoadTime(0);
        c1.text = "You reached Checkpoint 1 in " + temp + " seconds!";

        //c2
        temp = overlord.LoadTime(1);
        c2.text = "You reached Checkpoint 2 in " + temp + " seconds!";
        
        //c3
        temp = overlord.LoadTime(2);
        c3.text = "You reached Checkpoint 3 in " + temp + " seconds!";
        
        //c4
        temp = overlord.LoadTime(3);
        c4.text = "You reached Checkpoint 4 in " + temp + " seconds!";
       
        //c5
        temp = overlord.LoadTime(4);
        c5.text = "You reached Checkpoint 5 in " + temp + " seconds!";
        
        //display total
        temp = overlord.LoadTotalTime();
        total.text = "Total Time: " + temp + " seconds";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
