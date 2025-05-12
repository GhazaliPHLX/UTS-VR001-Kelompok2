using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollMovement : MonoBehaviour, ITriggerPolt
{
    
    public Transform wheelChair;
    public void triggerPolt()
    {
        wheelChair.localPosition = new Vector3(-12.379f, 8.291f, 4.077f);
        wheelChair.localRotation = Quaternion.Euler(-87.659f, 3.515f, -2.171f);
        
    }

}
