using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 10f;

    private Vector2 movementInput = Vector2.zero;
    
    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
        movementInput.Normalize();
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
    }

    private void FixedUpdate()
    {
        MoveInDirection();
    }

    private void MoveInDirection()
    {
        rb.velocity = movementInput * speed;
    }
}
