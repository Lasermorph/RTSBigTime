using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 movement;
    float XPosition;
    void Start()
    {
        movement = new Vector2(0.0f, 0.0f);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Xposition.x = position;
        }
        transform.position = Xposition;
    }
}
