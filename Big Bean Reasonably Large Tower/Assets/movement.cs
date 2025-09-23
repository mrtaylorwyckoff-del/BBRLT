using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float speed;
    public float jumpHeight = 1;


    public Rigidbody2D rb2d;

    private float _movement;
    private float _jump;

    // Update is called once per frame
    void Update()
    {
        // Set the velocity, scaling horizontal movement by speed
        rb2d.linearVelocity = new Vector2(_movement * speed, rb2d.linearVelocity.y);
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        _movement = ctx.ReadValue<Vector2>().x;
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        rb2d.linearVelocityX += 20;
        Debug.Log("Jumped" + rb2d.linearVelocityX);
    }
    }