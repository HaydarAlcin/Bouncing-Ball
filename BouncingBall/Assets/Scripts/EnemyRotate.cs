using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour
{
    public float rotateSpeed;

    private void FixedUpdate()
    {
        Rotate();
    }

    public void Rotate()
    {
        transform.Rotate(new Vector3(0,0,rotateSpeed*Time.fixedDeltaTime));
    }
}
