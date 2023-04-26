using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleRotate : MonoBehaviour
{
    public Transform nextCheckpoint;
    public Vector2 road;
    

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        

        if (this.gameObject.tag == "checkpoint3")
        {
            road = (nextCheckpoint.position - transform.position).normalized;
        }

        else
        {
            road = (nextCheckpoint.position - transform.position).normalized;
        }



    }
}
