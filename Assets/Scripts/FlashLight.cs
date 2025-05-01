using UnityEngine;

public class FlashlightFollowCamera : MonoBehaviour
{
    public Camera playerCam;
    void Update()
    {
        transform.rotation = playerCam.transform.rotation;
        transform.position = playerCam.transform.position;
    }
}
