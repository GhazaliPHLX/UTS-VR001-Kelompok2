using UnityEngine;

public class HandController : MonoBehaviour
{
    public Transform hand;
    public Transform playerCamera;
    public float mouseSensitivity = 0.5f;

    private Vector2 mouseInput;
    private Vector2 handRotation = Vector2.zero;

    // Offset posisi tangan dari bahu relatif ke arah kamera
    public Vector3 positionOffset = new Vector3(0.4f, -0.3f, 0.5f);
    public Vector3 rotationOffset = new Vector3(90f, -130f, -120f);

    private void LateUpdate()
    {
        // Posisi tangan selalu mengikuti kamera + offset dari posisi kamera (seolah dari bahu)
        hand.position = playerCamera.position
                      + playerCamera.right * positionOffset.x
                      + playerCamera.up * positionOffset.y
                      + playerCamera.forward * positionOffset.z;

        if (!Input.GetMouseButton(1))
        {
            // Tanpa klik kanan, tangan tetap mengikuti rotasi kamera
            hand.rotation = playerCamera.rotation * Quaternion.Euler(rotationOffset);
        }
        else
        {
            // Input mouse untuk rotasi tangan
            mouseInput.x += Input.GetAxis("Mouse X") * mouseSensitivity;
            mouseInput.y -= Input.GetAxis("Mouse Y") * mouseSensitivity;
            mouseInput.y = Mathf.Clamp(mouseInput.y, -80f, 80f);

            Quaternion handRot = Quaternion.Euler(mouseInput.y, mouseInput.x, 0);
            hand.rotation = playerCamera.rotation * handRot * Quaternion.Euler(rotationOffset);
        }
    }
}
