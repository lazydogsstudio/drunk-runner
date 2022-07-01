using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    [SerializeReference]
    float speed = 0.5f;

    [SerializeReference] float moveAxisSpeed = 0.05f;


    public bool isWalkStart = false;

    PlayerInput playerInput;
    PlayerAnimation playerAnimation;

    PlayerSwapMove playerSwapMove;


    private void Awake()
    {
        playerSwapMove = new PlayerSwapMove();
    }

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerAnimation = GetComponent<PlayerAnimation>();

    }


    void FixedUpdate()
    {

        if (isWalkStart)
        {
            transform.Translate(Vector3.forward * speed);
            playerAnimation.Walk(true);

        }

        if (!isWalkStart)
        {
            transform.Translate(Vector3.zero);
            playerAnimation.Walk(false);
        }

    }

    private void OnEnable()
    {
        playerSwapMove.SwapMove.Enable();
        playerSwapMove.SwapMove.Move.performed += OnMove;
    }

    private void OnDisable()
    {
        playerSwapMove.SwapMove.Disable();
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        Vector2 moveInput = context.ReadValue<Vector2>();

        if (isWalkStart)
        {
            if (transform.position.x < 2.5f)
                if (moveInput.normalized.x > 0f)
                    transform.Translate(Vector3.right * moveAxisSpeed);

            if (transform.position.x > -2.5f)
                if (moveInput.normalized.x < 0f)
                    transform.Translate(Vector3.left * moveAxisSpeed);
        }

    }
}
