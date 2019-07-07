using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("space pressed");
        }

        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            print("Rotating left");
        }

        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A))
        {
            print("Rotating right");
        }
    }
}
