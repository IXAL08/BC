using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
   public float depth = 1;
   
   Ground  velocity;

   private void Awake()
   {
       velocity = GameObject.Find("Ground").GetComponent<Ground>();
   }

   // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float realVelocity = velocity.speed / depth;
        Vector2 pos = transform.position;

        pos.x -= realVelocity * Time.fixedDeltaTime;
        if (pos.x <= -11)
        {
            pos.x = 11;
        }

        transform.position = pos;
    }
}
