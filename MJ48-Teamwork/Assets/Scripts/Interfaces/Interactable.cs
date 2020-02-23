using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Tuple
{
    public ItemType itemType;

    public int id;

    public Tuple(ItemType i1, int i2)
    {
        itemType = i1;
        id = i2;
    }
}



public abstract class IInteractable : MonoBehaviour
{

    public List<Tuple> itemReqs;

    public abstract void Interact();

}
