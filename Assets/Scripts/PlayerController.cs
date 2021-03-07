using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : Character
{

    [SerializeField] public float Speed;

    [SerializeField] private float rotationSpeed;

    [HideInInspector ]public Transform PlayerCamera;
    private Transform playerTransform;

    private Vector3 xDirection;
    private Vector3 zDirection;


    private void Start()
    { 
        animator = GetComponent<Animator>();
        playerTransform = GetComponent<Transform>();
        PlayerCamera = Camera.main.transform;
    }

    private void Update() 
    {
        xDirection = GetNewVector(PlayerCamera.right, Input.GetAxisRaw("Horizontal"));
        zDirection = GetNewVector(PlayerCamera.forward, Input.GetAxisRaw("Vertical"));
        playerTransform.position += (xDirection + zDirection) * Time.deltaTime * Speed;
        PlayerCamera.transform.position += xDirection * Time.deltaTime * Speed;
    }

    private Vector3 GetNewVector(Vector3 direction, float multyplier)
    {
        Vector3 newVector = new Vector3(direction.x, 0, direction.z) * multyplier;
        if(newVector != Vector3.zero)
        {
            Quaternion cameraRotation = Quaternion.Euler(0, PlayerCamera.eulerAngles.y, 0);
            playerTransform.rotation = Quaternion.RotateTowards(playerTransform.rotation, cameraRotation, rotationSpeed);
        }
        return newVector;
        
    }

}
