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

    FamiliarStatus status;

    Vector3 targetPosition;

    List<GameObject> targets;

    private void Start()
    {
        targets = new List<GameObject>();
        status = FamiliarStatus.FOLLOW;

        target.RegisterCFP(AwaitMove);
    }

    private void Update()
    {
        if(status == FamiliarStatus.FOLLOW)
            targetPosition = player.transform.position;
    }

    void FixedUpdate()
    {
        switch (status)
        {
            case FamiliarStatus.FOLLOW:
                SeekPlayer();
                break;
            case FamiliarStatus.MOVE:
                SeekPosition(0.1f, 0);
                break;
            case FamiliarStatus.ATTACK:
                Attack();
                break;
            case FamiliarStatus.INTERACT:
                break;
            case FamiliarStatus.RETRIEVE:
                break;
        }
    }

    void Attack()
    {
        Debug.Log("pew");
    }

    public void AwaitMove(FamiliarStatus command, Vector3 target)
    {
        status = command;
        if (command == FamiliarStatus.FOLLOW)
            targetPosition = player.transform.position;
        else
            targetPosition = target;
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

    public void FoundTarget(GameObject target)
    {
        status = FamiliarStatus.ATTACK;
        targets.Add(target);
        rb.velocity = Vector2.zero;
    }

    public void LostTarget(GameObject target)
    {
        targets.Remove(target);
        if (targets.Count == 0)
            status = FamiliarStatus.MOVE;
    }

}
