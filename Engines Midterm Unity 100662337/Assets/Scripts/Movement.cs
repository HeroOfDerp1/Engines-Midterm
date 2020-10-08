using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

//Kaylyn McCune - 100662337
//controls player movement

public class Movement : MonoBehaviour
{
    //declare variables
    float speed, rotSpeed;
    public Quaternion initialRot;

    // Start is called before the first frame update
    void Start()
    {
        //initialize variables
        speed = 0.01f;
        rotSpeed = 0.3f;
        initialRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        //the secret jump mechanic that can never see the light of day
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Vector3 position = transform.position;
        //    transform.position = position + new Vector3(0.0f, 1.0f, 0.0f);
        //}

        //movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + (transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + (-transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0.0f, -1.0f, 0.0f) * rotSpeed, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f) * rotSpeed, Space.World);
        }
        //resets the blocks rotation incase he rotates and you cant move properly
        if (Input.GetKey(KeyCode.R))
        {
            transform.rotation = initialRot;
        }
    }
}
