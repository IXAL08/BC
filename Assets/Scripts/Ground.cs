using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed, start, end;
    private bool acelerar = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        if (transform.position.x <= end)
        {
            if (gameObject.CompareTag("Enemigo"))
            {
                Destroy(gameObject);
            }
            else
            {
                transform.position = new Vector2(start, transform.position.y);
            }
            
        }
    }

    private void FixedUpdate()
    {
        if (acelerar && speed <= 40)
        {
            speed += 0.1f;
        }
        else
        {
            acelerar = false;
            speed -= 0.01f;
        }

        if (speed <= -0.1)
        {
            speed = 0;
        }
    }
}
