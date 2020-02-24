using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    //TODO Add logic for going through
    public bool requiresKey;
    

    public void ActivateDoor(bool isOpen)
    {
        GetComponent<DoorAnim>().SetDoorState(isOpen);
    }

    public void FlipState()
    {
        GetComponent<DoorAnim>().SetDoorState(!GetComponent<DoorAnim>().GetDoorState());
    }
}
