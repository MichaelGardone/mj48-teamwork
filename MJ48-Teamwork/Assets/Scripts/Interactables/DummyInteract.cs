using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyInteract : IInteractable
{
    public override void Interact()
    {
        Debug.Log("hello!");
    }
}
