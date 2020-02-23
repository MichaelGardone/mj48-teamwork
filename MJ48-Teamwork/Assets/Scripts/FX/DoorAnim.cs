using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour
{
    // Start is called before the first frame update
    bool open;
    int openValue;
    Animator anim;
    void Start()
    {
        openValue = Animator.StringToHash("Open");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    

    public void SetDoorState(bool state)
    {
        open = state;
        anim.SetBool(openValue, open);
        
    }

    public bool GetDoorState()
    {
        return open;
    }


}
