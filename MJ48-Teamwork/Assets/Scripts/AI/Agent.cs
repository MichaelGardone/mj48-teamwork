﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : IAgent
{
    [Header("AI Agent Information")]
    public float dummy;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
