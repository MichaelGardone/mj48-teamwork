using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Lever : IInteractable
{
    [SerializeField] LeverAnim anim;
    [SerializeField] List<Door> linkedRefs;
    bool leverState;
    public override void Interact() {
        leverState = !leverState;
        anim.SetLeverState(leverState);

        if(linkedRefs != null || linkedRefs.Count > 0)
        {
            foreach (Door d in linkedRefs)
            {
                d.FlipState();
            }
        }
        else
        {
            Debug.Log($"{gameObject.name} is not connected to any doors");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.TryGetComponent<Familiar>(out Familiar f)){
            if(f.status == FamiliarStatus.INTERACT)
            {
                Interact();
                f.status = FamiliarStatus.MOVE;
            }
        }
    }

    private void OnMouseDown()
    {
        Interact();
    }


}

