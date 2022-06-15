using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementDistance = 0.001f;

    [SerializeField] private Vector3 currPosition;

    // Update is called once per frame
    void Update()
    {
        currPosition = transform.position;
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(currPosition.x + movementDistance, currPosition.y, currPosition.z);
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(currPosition.x - movementDistance, currPosition.y, currPosition.z);
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(currPosition.x, currPosition.y + movementDistance, currPosition.z);
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(currPosition.x, currPosition.y - movementDistance, currPosition.z);
        }
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.position = new Vector3(currPosition.x, currPosition.y, currPosition.z + movementDistance);
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.position = new Vector3(currPosition.x, currPosition.y, currPosition.z - movementDistance);
        }
    }
}
