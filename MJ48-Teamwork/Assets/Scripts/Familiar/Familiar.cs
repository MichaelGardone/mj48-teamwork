using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Familiar : MonoBehaviour
{

    public float stopRadius = 2f;
    public float slowDownRadius = 3f;
    public float followSpeed = 5f;
    public float attackSpeed = 5f;

    public Player player;

    public Rigidbody2D rb;

    public Target target;

    FamiliarCommands status;

    Vector3 targetPosition;

    private void Start()
    {
        status = FamiliarCommands.FOLLOW;

        target.RegisterCFP(AwaitMove);
        target.RegisterCFGO(AwaitCommand);
    }

    private void Update()
    {
        if(status == FamiliarCommands.FOLLOW)
            targetPosition = player.transform.position;
    }

    void FixedUpdate()
    {
        switch (status)
        {
            case FamiliarCommands.FOLLOW:
                SeekPlayer();
                break;
            case FamiliarCommands.MOVE:
                SeekPosition(0.1f, 0);
                break;
            case FamiliarCommands.ATTACK:
                break;
            case FamiliarCommands.INTERACT:
                break;
            case FamiliarCommands.RETRIEVE:
                break;
        }

    }

    public void AwaitMove(FamiliarCommands command, Vector3 target)
    {
        status = command;
        if (command == FamiliarCommands.FOLLOW)
            targetPosition = player.transform.position;
        else
            targetPosition = target;
    }

    public void AwaitCommand(FamiliarCommands command, GameObject target)
    {
        status = command;
    }

    private void SeekPlayer()
    {
        float dist = Vector3.Distance(transform.position, targetPosition);
        if (dist > stopRadius)
        {
            // Vector in direction of player
            // Don't forget to standardize per frame
            Vector3 dir = (targetPosition - transform.position).normalized * Time.deltaTime;

            if (dist <= slowDownRadius)
                dir *= followSpeed * (dist / slowDownRadius);
            else
                dir *= (dist > 8) ? player.speed : followSpeed;

            // Move towards until we hit the player's stop zone
            rb.velocity = dir;
        }
        else
            rb.velocity = Vector2.zero;
    }

    private void SeekPosition(float stopRad, float slowDownRad)
    {
        float dist = Vector3.Distance(transform.position, targetPosition);
        if (dist > stopRad)
        {
            // Vector in direction of player
            // Don't forget to standardize per frame
            Vector3 dir = (targetPosition - transform.position).normalized * Time.deltaTime;

            if (dist <= slowDownRad)
                dir *= followSpeed * (dist / slowDownRadius);
            else
                dir *= followSpeed;

            // Move towards until we hit the player's stop zone
            rb.velocity = dir;
        }
        else
            rb.velocity = Vector2.zero;
    }

    private void Avoid()
    {

    }

}
