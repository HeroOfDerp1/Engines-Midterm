using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


//Kaylyn McCune - 100662337
//allows rotation of the camera independent of the player
//specifically lets the player look up and down using the arrow keys

public class CameraRotation : MonoBehaviour
{

    //declare variable
    public float speed;
    public float x,y,z;

    // Start is called before the first frame update
    void Start()
    {
        //initialize speed
        speed = 0.1f;
        x = 0;
        y = 0;
        z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //moves the camera on the local x axis to ensure it always moves up and down
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //old method of camera rotation
            //transform.Rotate(new Vector3(-1.0f, 0.0f, 0.0f) * speed, Space.Self);

            //sets the camera angles, and updates the y and z
            //makes x turn
            x = transform.localEulerAngles.x + (-1.0f * speed);
            y = transform.localEulerAngles.y;
            z = transform.localEulerAngles.z;

            //checks if the camera is outside of the designated rotation range
            //yes i know Mathf.Clamp exists, but my continous range of values are ones being excluded not included
            if (x >= 34 && x <=350)
            {
                //sets the camera to the apropriate up max
                x = 350.0f;
            }

            //transforms the camera
            transform.localEulerAngles = new Vector3(x,y,z);


        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //old method of camera rotation
            //transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f) * speed, Space.Self);

            //sets the camera angles, and updates the y and z
            //makes x turn
            x = transform.localEulerAngles.x + (1.0f * speed);
            y = transform.localEulerAngles.y;
            z = transform.localEulerAngles.z;

            //checks if the camera is outside of the designated rotation range
            //yes i know Mathf.Clamp exists, but my continous range of values are ones being excluded not included
            if (x >= 34 && x <= 350)
            {
                //sets the camera to the apropriate down max
                x = 34.0f;
            }

            //transforms the camera
            transform.localEulerAngles = new Vector3(x, y, z);
        }
    }
}
