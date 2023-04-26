using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleEnemyMove : MonoBehaviour
{
    public Transform[] checkpoints;

    Transform currentCheckpoint;

    public float speed;
    public int point=0;

    private void Awake()
    {
            
        currentCheckpoint = checkpoints[point];
    }

    private void FixedUpdate()
    {
        transform.Translate(currentCheckpoint.GetComponent<TriangleRotate>().road * speed * Time.fixedDeltaTime);

        if (transform.position.x - currentCheckpoint.GetComponent<TriangleRotate>().nextCheckpoint.position.x <=0.01f && transform.position.y - currentCheckpoint.GetComponent<TriangleRotate>().nextCheckpoint.position.y <= 0.01f)
        {
            if (point == 2)
            {
                currentCheckpoint = checkpoints[2];
                point = 0;
            }
            else if (point == 0)
            {
                currentCheckpoint = checkpoints[0];
                point = 1;
            }

            else if (point == 1)
            {
                currentCheckpoint = checkpoints[1];
                point = 2;
            }





        }
    }
}
