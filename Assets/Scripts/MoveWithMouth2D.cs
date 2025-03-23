using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithMouse2D : MonoBehaviour
{
    [Header("Movement")]

    public float xFactor = 1.0f;
    public float yFactor = 0.5f;

    void Update()
    {

        Vector3 mouseScreenPos = Input.mousePosition;


        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mouseScreenPos);

 
        mouseWorldPos.z = transform.position.z;


        mouseWorldPos.x *= xFactor;
        mouseWorldPos.y *= yFactor;


        transform.position = mouseWorldPos;
    }
}

