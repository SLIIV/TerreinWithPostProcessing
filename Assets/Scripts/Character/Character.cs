using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    [SerializeField] protected virtual Animator animator {get; set;}

    protected virtual void SetCharacterAnimation(AnimationClip clip)
    {
        animator.Play(clip.name);
    }
    protected virtual void SetCharacterAnimation(string parametrName, float value)
    {
        animator.SetFloat(parametrName, value);
        
    }

} 
