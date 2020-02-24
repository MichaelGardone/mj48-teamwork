using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    [Header("To change between player 1 and 2 sprites, just change the animator controller")]
    [SerializeField] bool running;
    private int movingHash;
    
    private Animator anim;
    void Start()
    {
        movingHash = Animator.StringToHash("Running");
        anim = GetComponent<Animator>();
    }

    public void SetisRunningState(bool state)
    {
        running = state;
        anim.SetBool(movingHash, running);

    }

    public bool GetisRunningState()
    {
        return running;
    }
}
