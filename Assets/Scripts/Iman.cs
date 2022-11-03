using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iman : MonoBehaviour,iCollector
{
    public static event Action OnImanCollected;

    
    // Start is called before the first frame update
    
    public void Collect()
    {
        Destroy(gameObject);
        OnImanCollected?.Invoke();
    }
}
