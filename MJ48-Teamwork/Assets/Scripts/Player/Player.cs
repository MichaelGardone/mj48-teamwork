using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed = 10f;
    public float maxSpeed = 10f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        // Update velocity
        rb.velocity = InputPoll.leftAnalog * Time.deltaTime * speed;
    }

}
