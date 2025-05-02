using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    public Transform hand;
    public float mouseSensitivity = 2f;
    private Vector3 handOffset;
    private Vector2 handRotation = Vector2.zero;

    public Transform playerCamera;



    private void Start()
    {
        // Hitung offset berdasarkan kamera, setelah semua referensi sudah valid
        handOffset = playerCamera.right * 0.4f    // kanan
                   + playerCamera.up * -0.3f      // sedikit ke bawah
                   + playerCamera.forward * 0.5f; // sedikit ke depan
    }

    private void LateUpdate()
    {
        hand.position = playerCamera.position
                  + playerCamera.right * 0.4f
                  + playerCamera.up * - 0.3f
                  + playerCamera.forward * 0.5f;

        // Bikin offset rotasi agar tangan miring sedikit
        if (!Input.GetMouseButton(1))
        {
            Quaternion rotationOffset = Quaternion.Euler(90f, -130f, -120f); // miring ke bawah dan ke kanan
            hand.rotation = playerCamera.rotation * rotationOffset;
        }
        else
        {
            hand.position = playerCamera.position
                  + playerCamera.right * 0.4f
                  + playerCamera.up * -0.3f
                  + playerCamera.forward * 0.5f;

            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

            handRotation.x += mouseX;
            handRotation.y -= mouseY;
            handRotation.y = Mathf.Clamp(handRotation.y, -45f, 45f);

            hand.rotation = playerCamera.rotation * Quaternion.Euler(handRotation.y, handRotation.x, 0f);
        }
    }
}
