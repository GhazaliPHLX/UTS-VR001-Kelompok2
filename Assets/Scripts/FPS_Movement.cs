using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Movement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 6f;

    public Transform orientation;

    private float horizontalInput;
    private float verticalInput;

    private Vector3 moveDirection;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        MyInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        // Langsung atur kecepatan tanpa drag
        Vector3 targetVelocity = moveDirection.normalized * moveSpeed;
        Vector3 velocityChange = targetVelocity - new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        rb.AddForce(new Vector3(velocityChange.x, 0, velocityChange.z), ForceMode.VelocityChange);
    }
}
