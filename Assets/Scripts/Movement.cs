using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    private bool isJumping;
    public GameManager gameManager;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && isJumping == false)
        {
            rb.velocity = new Vector3(0, 20,0);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        isJumping = false;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemigo")
        {
            gameManager.GameOver();
        }
    }
}
