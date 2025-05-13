using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SculptJumpscare : MonoBehaviour, ITriggerPolt
{
    public GameObject sculpt;
    public float forceAmount = 300f; // besarnya dorongan
    public Vector3 pushDirection = new Vector3(0, 0.5f, -1f);

    public void triggerPolt()
    {
        Rigidbody rb = sculpt.GetComponent<Rigidbody>();
        rb.AddForce(pushDirection.normalized * forceAmount, ForceMode.Impulse);
    }
}
