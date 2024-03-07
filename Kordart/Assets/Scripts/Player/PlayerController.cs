using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;

    private Vector2 moveInput;
    private Master controls;
    private Rigidbody2D body;

    private void Awake()
    {
        controls = new Master();
        body = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void FixedUpdate()
    {
        moveInput = controls.Player.Move.ReadValue<Vector2>();
        Vector2 movement = new Vector2(moveInput.x, moveInput.y) * moveSpeed;
        body.MovePosition(body.position + movement);
    }
}
