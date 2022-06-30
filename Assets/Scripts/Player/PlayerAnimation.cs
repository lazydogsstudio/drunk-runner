using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    Animator playerAnimator;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    public void WalkingState(float value)
    {
        playerAnimator.SetFloat("walkingTree", value);
    }

    public void Walk(bool isWalk)
    {
        playerAnimator.SetBool("isWalking", isWalk);
    }

    public void Dance()
    {
        playerAnimator.SetTrigger("Dance");
    }

    public void Fall()
    {
        playerAnimator.SetTrigger("Fall");
    }
}
