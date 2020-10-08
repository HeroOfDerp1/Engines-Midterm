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
    public Vector3 up;

    // Start is called before the first frame update
    void Start()
    {
        //initialize speed
        speed = 0.1f;
        up = transform.up;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(-1.0f, 0.0f, 0.0f) * speed, Space.Self);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f) * speed, Space.Self);
        }
        up = transform.up;
    }
}
