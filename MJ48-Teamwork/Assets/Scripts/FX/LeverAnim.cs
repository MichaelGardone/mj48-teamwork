using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverAnim : MonoBehaviour
{
    bool isON;
    int onValue;
    Animator anim;
    void Start()
    {
        onValue = Animator.StringToHash("LeverON");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame


    public void SetLeverState(bool state)
    {
        isON = state;
        anim.SetBool(onValue, isON);

    }

    public bool GetLeverState()
    {
        return isON;
    }

}
