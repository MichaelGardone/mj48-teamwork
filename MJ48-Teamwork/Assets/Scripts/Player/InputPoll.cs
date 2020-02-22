using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputPoll : MonoBehaviour
{
    Inputs input;

    public static Vector2 leftAnalog;
    public static Vector2 rightAnalog;

    public static bool ResetRightAnalog;

    private void Awake()
    {
        input = new Inputs();
        
        input.Controller.LeftAnalog.performed += ctx => leftAnalog = ctx.ReadValue<Vector2>();
        input.Controller.LeftAnalog.canceled += ctx => leftAnalog = Vector2.zero;

        input.Controller.RightAnalog.performed += ctx => rightAnalog = ctx.ReadValue<Vector2>();
        input.Controller.RightAnalog.canceled += ctx => rightAnalog = Vector2.zero;

        input.Controller.RightAnalogDown.performed += ctx => ResetRightAnalog = true;
        input.Controller.RightAnalogDown.canceled += ctx => ResetRightAnalog = false;
    }

    private void OnEnable()
    {
        input.Controller.Enable();
    }

    private void OnDisable()
    {
        input.Controller.Disable();
    }
}
