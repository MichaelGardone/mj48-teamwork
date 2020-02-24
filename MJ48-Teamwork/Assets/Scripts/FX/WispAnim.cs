using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WispAnim : MonoBehaviour
{
    // Start is called before the first frame update
    private int attackingHash;
    bool attacking;
    private Animator anim;
    void Start()
    {
        attackingHash = Animator.StringToHash("Attacking");
        anim = GetComponent<Animator>();
    }

    public void SetAttackingState(bool state)
    {
        attacking = state;
        anim.SetBool(attackingHash, attacking);

    }

    public bool GetAttackingState()
    {
        return attacking;
    }
}
