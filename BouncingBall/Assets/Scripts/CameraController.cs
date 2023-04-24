using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Takip edilecek hedef
    public float smoothSpeed = 0.125f; // Takip hýzý
    public Vector3 offset; // Hedefin konumu ile arasindaki fark

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Slerp(new Vector3(0,transform.position.y,-10), new Vector3(0, desiredPosition.y,-10), smoothSpeed);
        transform.position = smoothedPosition;
    }
}
