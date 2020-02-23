using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    public bool open;
    int openValue;
    Animator anim;
    void Start()
    {
        openValue = Animator.StringToHash("Open");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        anim.SetBool(openValue, open);
    }
}
