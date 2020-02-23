using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 2;
    public Rigidbody2D rb;
    public float timeUntilGo = 0.75f;

    float timer = 0;
    private Transform target;
    private bool go = false;
    private Vector3 offset;
    private Transform familiar;
    Vector3 safeCheck = Vector3.zero;

    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    public void SetGoStatus(bool status)
    {
        go = status;
    }

    public void SetOffset(Vector3 offset)
    {
        this.offset = offset;
    }

    public void FollowMe(Transform familiar)
    {
        this.familiar = familiar;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeUntilGo)
            go = true;

        if (target != null)
            safeCheck = target.position;

        if (go)
        {
            rb.velocity = (safeCheck - transform.position).normalized * Time.deltaTime * speed;
        }
        else
        {
            transform.position = familiar.position + offset;
        }

        if (Vector3.Distance(transform.position, safeCheck) < 0.1f && gameObject.activeSelf)
            gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        familiar.gameObject.GetComponent<Familiar>().currActiveProjs--;
        go = false;
        timer = 0;
    }
}
