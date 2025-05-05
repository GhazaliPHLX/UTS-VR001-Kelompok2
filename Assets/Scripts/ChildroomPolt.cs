using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildroomPolt : MonoBehaviour , ITrigger
{
    public AudioSource doorBam;
    public GameObject door1;
    public GameObject door2;
    public void trigger()
    {
        //doorBam.Play();
        CloseDoor doorScript = door1.GetComponent<CloseDoor>();
        if(doorScript != null)
        {
            doorScript.Interact();
            Debug.Log("DoorClosed");
        }

        CloseDoor doorScript1= door2.GetComponent<CloseDoor>();
        if (doorScript1!= null)
        {
            doorScript1.Interact();
            Debug.Log("DoorClosed");

        }


    }

    

}
