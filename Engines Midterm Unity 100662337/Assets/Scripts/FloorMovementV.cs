﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Kaylyn McCune - 100662337
//moves the vertical moving floor tiles back and forth

public class FloorMovementV : MonoBehaviour
{

    //declare variables needed
    public Vector3 startpos, endpos, temp;
    public float t;
    public bool foward;

    // Start is called before the first frame update
    void Start()
    {
        //initialize variables
        startpos = transform.position;
        endpos = startpos - new Vector3(0.0f, 0.0f, 8.5f);
        temp = new Vector3(0.0f, 0.0f, 0.0f);
        t = 0;
        foward = true;
    }

    // Update is called once per frame
    void Update()
    {
        //lerps between the start and end point based on t, then updates the position
        temp = Vector3.Lerp(startpos, endpos, t);
        transform.position = temp;

        //checks if t should be increasing or decreasing, then performs the apropriate operation
        if (foward)
        {
            t += 0.0005f * 600.0f * Time.deltaTime;
        }
        else
        {
            t -= 0.0005f * 600.0f * Time.deltaTime;
        }

        //checks the value of t and changes the bool once it hits 1 or 0
        if (t >= 1.0f)
        {
            foward = false;
        }
        if (t <= 0.0f)
        {
            foward = true;
        }
    }
}

