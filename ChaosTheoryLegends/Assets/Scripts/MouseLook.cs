using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    [Header("Sensitivity")] 
    [SerializeField] private float mouseXSensitivity;
    [SerializeField] private float mouseYSensitivity;

    [Header("References")] 
    [SerializeField] private Transform playerObjectTransform;
    [SerializeField] private Camera playerCamera;

    private void Update()
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        mousePosition = playerCamera.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(mousePosition.x - playerObjectTransform.position.x, mousePosition.y - playerObjectTransform.position.y);
        playerObjectTransform.up = direction;
    }
}
