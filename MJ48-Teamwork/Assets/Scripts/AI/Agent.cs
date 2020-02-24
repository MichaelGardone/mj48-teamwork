using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : IAgent
{
    [Header("AI Agent Information")]
    public AStar pathfinding;
    public GameObject player;
    public Rigidbody2D rb;
    public float moveSpeed = 100f;

    List<Node> path;

    Vector3 targetPosition = new Vector3(0,0,-100);
    Vector3 unset = new Vector3(0, 0, -100);

    bool targetNotSet = true;

    void Start()
    {
        health = maxHealth;
        path = pathfinding.FindPath(transform.position, player.gameObject.transform.position);

        targetPosition = unset;
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
            if (Vector3.Distance(transform.position, targetPosition) <= 0.25f || targetPosition == unset)
            {
                targetPosition = pathfinding.grid.WorldPointFromNode(path[0]);
                targetPosition.z = 0;
                path.RemoveAt(0);
            }

            if (targetPosition != unset)
            {
                Vector3 dir = (targetPosition - transform.position).normalized * Time.deltaTime * moveSpeed;
                rb.velocity = dir;
            }
        }

        if (path.Count == 0 && Vector3.Distance(transform.position, targetPosition) <= 0.5f)
        {
            rb.velocity = Vector2.zero;
            targetPosition = unset;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health -= collision.gameObject.GetComponent<Projectile>().damage;
    }
}
