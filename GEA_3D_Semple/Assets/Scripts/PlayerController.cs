using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpPower = 5f;
    public float gravity = -20f;
    public float mouseSensitivity = 0.2f;
    private Vector2 lookInput;
    private bool isRunning;
    public Transform cameraPivot;
    public Transform cameraTransfrom;
    private float pitch = 20f;

    private float verticalValocity;

    private Vector2 moveInput;
    private CharacterController controller;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, lookInput.x * mouseSensitivity, 0f);
        pitch = pitch - lookInput.y * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, -20f, 60f);
        cameraPivot.localEulerAngles = new Vector3(pitch, 0f, 0f);

        if (controller.isGrounded && verticalValocity < 0f)
        {
            verticalValocity = -2f;
        }

        verticalValocity += gravity * Time.deltaTime;

        Vector3 move = transform.forward * moveInput.y + transform.right * moveInput.x;
        float speed = moveSpeed;
        float targetZ = -3f;
        if (isRunning)
        {
            speed = moveSpeed * 2f;
            targetZ = -5f;
        }
        move = move * speed;
        move.y = verticalValocity;

        Vector3 camPos = cameraTransfrom.localPosition;
        camPos.z = Mathf.Lerp(camPos.z, targetZ, 5f * Time.deltaTime);
        cameraTransfrom.localPosition = camPos;

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

    public void OnSprint(InputValue value)
    {
        isRunning = value.isPressed;
    }

    public void OnLook(InputValue value)
    {
        lookInput = value.Get<Vector2>();
    }
}
