using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRoomJump : MonoBehaviour, ITrigger
{
    public AudioClip doorBam;
    public GameObject door1;
    public GameObject jumpScare;
    public void trigger()
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
