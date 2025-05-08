using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRoomJump : MonoBehaviour, ITriggerPolt
{
    public AudioClip doorBam;
    public GameObject door1;
    public GameObject jumpScare;
    public void triggerPolt()
    {
        
        CloseDoor doorScript = door1.GetComponent<CloseDoor>();
        if (doorScript != null)
        {
            doorScript.Interact();
            AudioSource.PlayClipAtPoint(doorBam, door1.transform.position);
            jumpScare.SetActive(true);
        }
    }
}
