using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator animator;

    public void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnMouseDown()
    {
        animationVariable = (animationVariable + 1) % 3;
        animator.SetInteger("state", animationVariable);
        Debug.Log($"animationVariable : {animationVariable}");
    }
}
