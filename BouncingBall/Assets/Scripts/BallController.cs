using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody2D rb;

    //Her dokunustaki kuvvet
    public float force;

    //Oyuna baslamayi kontrol eden degisken
    public bool gameStart;

    
    
    private void Start()
    {
        gameStart = true;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        FirstTouch();
    }


    public void FirstTouch()
    {
        if (Input.GetAxisRaw("Jump")==1)
        {   

            if (gameStart==true)
            {
                gameStart = false;
                rb.bodyType = RigidbodyType2D.Dynamic;
            }
            rb.velocity =  new Vector2(0,1);
            rb.AddRelativeForce(new Vector2(0, force * Time.deltaTime));
        }
        
    }
}
