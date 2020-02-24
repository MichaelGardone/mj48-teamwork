using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    //TODO Add logic for going through
    public bool requiresKey;
    public bool isOpen;
    private DoorAnim anim;
    [SerializeField] Door warpTarget;
    public bool stopRegisteringTrigger;
    private void Awake()
    {
        anim.SetDoorState(isOpen);
    }

    public void ActivateDoor(bool _isOpen)
    {
        GetComponent<DoorAnim>().SetDoorState(_isOpen);
        isOpen = _isOpen;
    }

    public void FlipState()
    {
        anim.SetDoorState(!anim.GetDoorState());
        isOpen = !isOpen;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (stopRegisteringTrigger) { return; }

        if (other.CompareTag("Player") && warpTarget != null && isOpen)
        {
            other.transform.position = warpTarget.transform.position;
            warpTarget.stopRegisteringTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") )
        {
            
            stopRegisteringTrigger = false;
        }
    }
}
