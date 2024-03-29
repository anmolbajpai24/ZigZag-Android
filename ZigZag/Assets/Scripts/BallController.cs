﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float speed;
    bool started;
    bool gameOver();

    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Start is called before the first frame update
    void Start()
    {
        // Started will be false by default but doing this just to confirm

        started = false;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!started)
        {
            if(Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                started = true;
            }
        }
        
        transform.Translate()

        Physics.Raycast()

        if (Input.GetMouseButtonDown(0) && !gameOver)
        {
            SwitchDirection();
        }


    }

    void SwitchDirection()
    {

        if(rb.velocity.z>0)
        {
            rb.velocity = new Vector3(speed, 0, 0);

        }

        else if(rb.velocity.x>0)
        {
            rb.velocity = new Vector3(0, 0, speed);

        }



    }

}
