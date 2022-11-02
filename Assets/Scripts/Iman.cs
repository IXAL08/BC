using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iman : MonoBehaviour,iCollector
{
    public static event Action OnImanCollected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Collect()
    {
        Destroy(gameObject);
        OnImanCollected?.Invoke();
    }
}
