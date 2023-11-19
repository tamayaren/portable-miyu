using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void Reset()
    {
        animator.SetBool("Looking", false);
        animator.SetBool("Shy", false);
    }

    public void Looking()
    {
        this.Reset();
        animator.SetBool("Looking", true);
    }

    public void Shy()
    {
        this.Reset();
        animator.SetBool("Shy", true);
    }
}
