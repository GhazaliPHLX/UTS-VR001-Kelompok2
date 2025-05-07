using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera Playercam;

    void Update()
    {
        // Ambil arah forward kamera
        Vector3 camForward = Playercam.transform.forward;

        // Buang komponen vertikal (Y) agar hanya ikut arah horizontal
        camForward.y = 0;

        // Normalisasi agar arah tetap akurat
        camForward.Normalize();

        // Atur arah objek ke arah horizontal kamera
        transform.forward = camForward;
    }
}
