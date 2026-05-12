using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
    public CharacterController controller;

    [Header("Movement")]
    public float walkSpeed = 5.5f;
    public float sprintSpeed = 9f;
    public float acceleration = 10f;
    public float deceleration = 12f;

    private Vector3 currentVelocity;

    [Header("Jump & Gravity")]
    public float gravity = -20f;
    public float jumpHeight = 2f;

    public Transform groundCheck;
    public float groundDistance = 0.3f;
    public LayerMask groundMask;

    private Vector3 velocity;
    private bool isGrounded;
    private bool wasGrounded;

    [Header("Camera")]
    public Transform cameraHolder;

    [Header("Head Bob")]
    public float bobSpeed = 12f;
    public float bobAmount = 0.04f;
    public float bobSideAmount = 0.025f;

    private float defaultYPos;
    private float defaultXPos;
    private float timer;

    [Header("Camera Tilt")]
    public float tiltAmount = 5f;
    public float tiltSpeed = 5f;
    private float currentTilt;

    [Header("Landing Effect")]
    public float landingDip = 0.1f;
    public float landingSpeed = 6f;
    private float landingOffset;

    [Header("Footsteps")]
    public AudioSource footstepAudio;

    void Start()
    {
        defaultYPos = cameraHolder.localPosition.y;
        defaultXPos = cameraHolder.localPosition.x;
    }

    void Update()
    {
        wasGrounded = isGrounded;
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        bool isSprinting = Input.GetKey(KeyCode.LeftShift);
        float targetSpeed = isSprinting ? sprintSpeed : walkSpeed;

        Vector3 forward = cameraHolder.forward;
        Vector3 right = cameraHolder.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        Vector3 targetMove = (forward * z + right * x).normalized * targetSpeed;

        float accel = (targetMove.magnitude > 0.1f) ? acceleration : deceleration;
        currentVelocity = Vector3.Lerp(currentVelocity, targetMove, accel * Time.deltaTime);

        controller.Move(currentVelocity * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (!wasGrounded && isGrounded)
        {
            landingOffset = -landingDip;
        }

        landingOffset = Mathf.Lerp(landingOffset, 0f, Time.deltaTime * landingSpeed);

        bool isMoving = currentVelocity.magnitude > 0.1f && isGrounded;


        if (isMoving)
        {
            if (!footstepAudio.isPlaying)
            {
                float basePitch = isSprinting ? 1.2f : 1f;

                footstepAudio.pitch = Random.Range(basePitch - 0.05f, basePitch + 0.05f);

                footstepAudio.Play();
            }
        }
        else
        {
            footstepAudio.Stop();
        }

        float bobY = 0f;
        float bobX = 0f;

        if (isMoving)
        {
            float speedMultiplier = isSprinting ? 1.6f : 1f;
            timer += Time.deltaTime * bobSpeed * speedMultiplier;

            bobY = Mathf.Sin(timer) * bobAmount;
            bobX = Mathf.Cos(timer / 2f) * bobSideAmount;
        }
        else
        {
            timer = 0;
        }

        float targetTilt = -x * tiltAmount;
        currentTilt = Mathf.Lerp(currentTilt, targetTilt, Time.deltaTime * tiltSpeed);

        Vector3 targetPos = new Vector3(
            defaultXPos + bobX,
            defaultYPos + bobY + landingOffset,
            cameraHolder.localPosition.z
        );

        cameraHolder.localPosition = Vector3.Lerp(
            cameraHolder.localPosition,
            targetPos,
            Time.deltaTime * 8f
        );

        cameraHolder.localRotation = Quaternion.Euler(0f, 0f, currentTilt);
    }
}