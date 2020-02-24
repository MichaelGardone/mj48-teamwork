using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : IAgent
{
    [Header("AI Agent Information")]
    public AStar pathfinding;
    public GameObject player;
    List<Node> path;

    Vector3 currPosition;

    void Start()
    {
        health = maxHealth;
        path = pathfinding.FindPath(transform.position, player.gameObject.transform.position);
    }

    void Update()
    {
        if (health <= 0)
            Destroy(gameObject);

    }

    private void FixedUpdate()
    {
        if (path.Count > 0)
        {
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health -= collision.gameObject.GetComponent<Projectile>().damage;
    }
}
