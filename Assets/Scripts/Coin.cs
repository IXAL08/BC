using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Coin : MonoBehaviour, iCollector
{
    public static event Action OnCoinCollected;
    private Rigidbody2D rb;
    private bool hasTarget;
    private Vector3 Targetposition;
    public float moveSpeed = 5;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Collect()
    {
        Destroy(gameObject);
        OnCoinCollected?.Invoke();
    }

    private void FixedUpdate()
    {
        if (hasTarget)
        {
            Vector2 targetDirection = (Targetposition - transform.position).normalized;
            rb.velocity = new Vector2(targetDirection.x, targetDirection.y) * moveSpeed;
        }
    }

    public void SetTarget(Vector3 position)
    {
        Targetposition = position;
        hasTarget = true;
    }
}
