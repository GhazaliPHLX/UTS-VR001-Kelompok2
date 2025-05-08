using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollMovement : MonoBehaviour, ITriggerPolt
{
    
    public Transform wheelChair;
    public void triggerPolt()
    {
        wheelChair.position = new Vector3(-12.181f, 8.329f, 4.087f);
        wheelChair.rotation = Quaternion.Euler(-87.659f, 3.515f, -362.171f);
        
    }

}
