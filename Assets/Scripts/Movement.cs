using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    private bool isJumping;
    public float duracion = 5f;
    public GameManager gameManager;
    public CircleCollider2D RangoIman;
    public CircleCollider2D RangoCollector;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
        RangoIman.enabled = false;
        RangoCollector.enabled = false;
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
        if (col.CompareTag("Iman"))
        {
            StartCoroutine(IPowerup(duracion));
        }
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            gameManager.GameOver();
        }
    }

    IEnumerator IPowerup(float seconds)
    {
        RangoIman.enabled = true;
        RangoCollector.enabled = true;
        yield return new WaitForSeconds(seconds);
        RangoIman.enabled = false;
        RangoCollector.enabled = false;

    }
}
