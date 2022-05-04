using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Start()
    {

    }
    public Vector2 targetPosition;
   
    // Update is called once per frame
    void Update () {
 
        if(Input.GetKeyDown(KeyCode.Mouse0))
           {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
 
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);
    }
}
