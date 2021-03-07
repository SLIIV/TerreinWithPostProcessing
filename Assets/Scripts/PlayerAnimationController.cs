using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerAnimationController : MonoBehaviour
{


    private Animator playerAnimator;
    private PlayerController playerController;

    private void Start() 
    {    
        playerAnimator = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();
        playerAnimator.speed = playerController.Speed / 4;
    }

    void Update() 
    {
        SetCharacterAnimation("xDirection", Input.GetAxisRaw("Horizontal"));
        SetCharacterAnimation("zDirection", Input.GetAxisRaw("Vertical"));
    }
    private void SetCharacterAnimation(string paramName, float value)
    {
        playerAnimator.SetFloat(paramName, value);
    }

}

