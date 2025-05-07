using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera Playercam;
    
    // Update is called once per frame
    void Update()
    {
        transform.forward = Playercam.transform.forward;

    }
}
