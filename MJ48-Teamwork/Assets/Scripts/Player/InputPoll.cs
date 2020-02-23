using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputPoll : MonoBehaviour
{
    Inputs input;

    // Thumbsticks
    public static Vector2 leftAnalog;
    public static Vector2 rightAnalog;
    public static bool ResetRightAnalog;

    // Secondary
    public static bool PauseButtonPressed;

    // Face buttons
    public static bool WestButtonPressed;
    public static bool NorthButtonPressed;
    public static bool SouthButtonPressed;

    private void Awake()
    {
        input = new Inputs();
        
        input.Controller.LeftAnalog.performed += ctx => leftAnalog = ctx.ReadValue<Vector2>();
        input.Controller.LeftAnalog.canceled += ctx => leftAnalog = Vector2.zero;

        input.Controller.RightAnalog.performed += ctx => rightAnalog = ctx.ReadValue<Vector2>();
        input.Controller.RightAnalog.canceled += ctx => rightAnalog = Vector2.zero;

        input.Controller.RightAnalogDown.performed += ctx => ResetRightAnalog = true;
        input.Controller.RightAnalogDown.canceled += ctx => ResetRightAnalog = false;

        input.Controller.North.performed += ctx => NorthButtonPressed = true;
        input.Controller.North.canceled += ctx => NorthButtonPressed = false;
        
        input.Controller.West.performed += ctx => WestButtonPressed = true;
        input.Controller.West.canceled += ctx => WestButtonPressed = false;

        input.Controller.South.performed += ctx => SouthButtonPressed = true;
        input.Controller.South.canceled += ctx => SouthButtonPressed = false;

        input.Controller.Start.performed += ctx => PauseButtonPressed = true;
        input.Controller.Start.canceled += ctx => PauseButtonPressed = false;
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
