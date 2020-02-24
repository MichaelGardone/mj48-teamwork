using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : IAgent
{
    [Header("Player Information")]
    public Rigidbody2D rb;

    public float speed = 10f;
    public float maxSpeed = 10f;

    public List<IItem> inventory;

    void Start()
    {
        inventory = new List<IItem>();
        maxHealth = 100;
        health = maxHealth;
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        // Update velocity
        rb.velocity = InputPoll.leftAnalog * Time.deltaTime * speed;
    }

    public void AddItem(IItem item)
    {
        inventory.Add(item);
    }

}
