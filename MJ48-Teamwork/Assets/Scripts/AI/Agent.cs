using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : IAgent
{
    [Header("AI Agent Information")]
    public float dummy;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        if (health <= 0)
            Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health -= collision.gameObject.GetComponent<Projectile>().damage;
    }
}
