using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Familiar : MonoBehaviour
{

    public float stopRadius = 2f;
    public float slowDownRadius = 3f;
    public float chaseSpeed = 5f;
    public float commandSpeed = 5f;

    public Player player;

    public Rigidbody2D rb;

    void FixedUpdate()
    {
        SeekAndArrive();
    }

    private void SeekAndArrive()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);
        if (dist > stopRadius)
        {
            // Vector in direction of player
            // Don't forget to standardize per frame
            Vector3 target = (player.transform.position - transform.position).normalized * Time.deltaTime;

            if (dist <= slowDownRadius)
                target *= chaseSpeed * (dist / slowDownRadius);
            else
                target *= (dist > 8) ? player.speed : chaseSpeed;

            // Move towards until we hit the player's stop zone
            rb.velocity = target;
        }
        else
            rb.velocity = Vector2.zero;
    }

    private void Avoid()
    {

    }

}
