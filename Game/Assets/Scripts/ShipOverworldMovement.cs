﻿using UnityEngine;
using System.Collections;

public class ShipOverworldMovement : MonoBehaviour
{

    private Vector3 Destination;
    public float Movespeed = 1.0f;
    static public bool CanMove = true;

    // Use this for initialization
    void Start()
    {
        EnterOverworld();
    }

    void EnterOverworld()
    {
        Destination = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Globals.state == Globals.GameState.OVERWORLD && CanMove)
        {
            if (Vector3.Distance(transform.position, Destination) > 1.0f)
            {
                Vector3 direction = Destination - transform.position;
                direction.Normalize();
                direction.z = 0;
                direction *= Movespeed;
                direction *= Time.deltaTime;

                Vector3 newPos = transform.position;
                newPos.x += direction.x;
                newPos.y += direction.y;
                transform.position = newPos;
                Debug.Log(transform.position);

                //camera move check
                if (transform.position.y > Camera.main.transform.position.y)
                {
                    Vector3 newCameraPosition = Camera.main.transform.position;
                    newCameraPosition.y = transform.position.y;
                    Camera.main.transform.position = newCameraPosition;
                }
            }
            if (Input.GetMouseButtonDown(0))
            {
                SetNewDestination();
            }
        }
    }

    void SetNewDestination()
    {
        Destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Destination.z = 0;
        //Aim player at mouse
        //which direction is up
        Vector3 upAxis = new Vector3(0, 0, -1);
        Vector3 mouseScreenPosition = Input.mousePosition;
        //set mouses z to your targets
        mouseScreenPosition.z = transform.position.z;
        Vector3 mouseWorldSpace = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        transform.LookAt(mouseWorldSpace, upAxis);
        //zero out all rotations except the axis I want
        transform.eulerAngles = new Vector3(-transform.eulerAngles.z, 0, 0);
        
    }
}
