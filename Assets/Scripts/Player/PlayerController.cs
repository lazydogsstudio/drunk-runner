using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    [SerializeReference]
    float speed = 0.5f;


    public bool isWalkStart = false;

    PlayerInput playerInput;
    PlayerAnimation playerAnimation;


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



        Vector2 o = playerInput.actions["Move"].ReadValue<Vector2>();


        // print(o);

    }
}
