using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    Rigidbody2D rb;

    public GameObject gameOverPnl;

    //Her dokunustaki kuvvet
    public float force;

    //Oyuna baslamayi kontrol eden degisken
    public bool gameStart;

    
    
    private void Awake()
    {
        gameStart = true;
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        
             if (gameStart == true)
             {
                gameStart = false;
                rb.bodyType = RigidbodyType2D.Dynamic;
                rb.AddRelativeForce(new Vector2(0, -25f * Time.deltaTime));
            }
             rb.velocity = new Vector2(0, 1);
             rb.AddRelativeForce(new Vector2(0, force * Time.deltaTime));
          
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="enemy")
        {
            Debug.Log("GameOver");
            gameOverPnl.SetActive(true);
            Time.timeScale = 0f;

        }
    }



    public void TryAgainBtn() 
    {
        
        SceneManager.LoadScene(0);

    }
}
