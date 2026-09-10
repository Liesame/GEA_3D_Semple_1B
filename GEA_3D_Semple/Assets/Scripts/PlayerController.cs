using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpPower = 5f;
    public float gravity = -20f;

    private float verticalValocity;

    private Vector2 moveInput;
    private CharacterController controller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controller.isGrounded && verticalValocity < 0f)
        {
            verticalValocity = -2f;
        }

        verticalValocity += gravity * Time.deltaTime;

        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        move = move * moveSpeed;
        move.y = verticalValocity;

        controller.Move(move * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if(value.isPressed && controller.isGrounded)
        {
            verticalValocity = jumpPower;
        }
    }
}
