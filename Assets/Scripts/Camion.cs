using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camion : MonoBehaviour
{
   
   
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
        float realVelocity = velocity.speed / 2;
        Vector2 pos = transform.position;

        pos.x -= realVelocity * Time.fixedDeltaTime;
        
        

        transform.position = pos;
    }
}
