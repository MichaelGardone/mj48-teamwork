using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Replace with ScriptableObject, better behavior that way
public abstract class IItem : MonoBehaviour
{

    protected ItemType itemType;
    public float cooldownDropTime = 2f;
    protected float timer = 0f;

}
