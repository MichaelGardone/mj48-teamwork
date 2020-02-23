using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Familiar : IAgent
{
    [Header("Familiar Information")]
    public float stopRadius = 2f;
    public float slowDownRadius = 3f;
    public float followSpeed = 5f;
    public float attackSpeed = 5f;

    public int maxActiveMagicalBalls = 4;
    public int projectilePoolSize = 8;

    public GameObject proj;
    public GameObject[] projPool;
    
    public Player player;
    public Rigidbody2D rb;
    public Target target;

    public float relationship = 0.25f;

    FamiliarStatus status;

    Vector3 targetPosition;

    List<GameObject> targets;

    [HideInInspector]
    public int currActiveProjs = 0;

    int currIndex = 0;

    bool inSpawn = false;

    IItem slot;

    private void Start()
    {
        targets = new List<GameObject>();
        status = FamiliarStatus.FOLLOW;

        target.RegisterCFP(AwaitMove);

        projPool = new GameObject[projectilePoolSize];
        for(int i = 0; i < projectilePoolSize; i++)
        {
            GameObject t = Instantiate(proj);
            t.GetComponent<Projectile>().FollowMe(transform);
            t.SetActive(false);
            projPool[i] = t;
        }
    }

    private void Update()
    {
        if(status == FamiliarStatus.FOLLOW)
            targetPosition = player.transform.position;

        if (targets.Count > 0 && status != FamiliarStatus.ATTACK)
            status = FamiliarStatus.ATTACK;

        if (targets.Count > 0 && targets[0] == null)
            targets.RemoveAt(0);

        if (targets.Count == 0 && status == FamiliarStatus.ATTACK)
            status = FamiliarStatus.MOVE;

        if(Vector3.Distance(transform.position, player.gameObject.transform.position) < stopRadius && slot != null)
        {
            player.AddItem(slot);
            Destroy(slot.gameObject);
            slot = null;
        }
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
                SeekPosition(0.1f, 0);
                if (targets.Count >= 1 && Vector3.Distance(transform.position, targets[0].transform.position) < 2f)
                    rb.velocity = Vector2.zero;
                Attack();
                break;
            case FamiliarStatus.INTERACT:
                SeekPosition(0.1f, 0);
                break;
            case FamiliarStatus.RETRIEVE:
                SeekPosition(0.1f, 0);
                break;
        }
    }

    void Attack()
    {
        if (inSpawn == false && currActiveProjs < maxActiveMagicalBalls)
            StartCoroutine(SpawnProjectiles());
    }

    IEnumerator SpawnProjectiles()
    {
        inSpawn = true;
        while(currActiveProjs < maxActiveMagicalBalls)
        {
            GameObject t = projPool[currIndex];
            Vector3 offset = new Vector3(Random.Range(1f, 1.5f) * MoreRandom.Pick(-1, 1), Random.Range(1f, 1.5f) * MoreRandom.Pick(-1, 1), 0);
            t.transform.position = transform.position + offset;
            t.GetComponent<Projectile>().SetOffset(offset);
            if (targets.Count == 0 || targets[0] == null)
            {
                inSpawn = false;
                yield break;
            }
            t.GetComponent<Projectile>().SetTarget(targets[0].transform);
            t.SetActive(true);

            currIndex++;
            if (currIndex >= projPool.Length)
                currIndex = 0;
            currActiveProjs++;
            yield return new WaitForSeconds(Random.Range(0.25f, 0.4f));
        }
        inSpawn = false;
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

    public void Pickup(IItem item)
    {
        if(slot == null)
            slot = item;
        else
        {
            slot.gameObject.transform.parent = null;
            slot.gameObject.transform.localScale = new Vector3(1, 1, 1);
            slot.gameObject.transform.position = item.gameObject.transform.position + new Vector3(0.25f, 0, 0);
            slot.gameObject.GetComponent<BoxCollider2D>().enabled = true;

            slot = item;
        }

        rb.velocity = Vector2.zero;
        status = FamiliarStatus.FOLLOW;
    }

}
