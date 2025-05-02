using UnityEngine;

public class DoorScript : MonoBehaviour, IInteractable
{
    public GameObject doorOpen;
    public GameObject doorClose;

    private bool isOpen = false;

    public void Interact()
    {
        if (isOpen)
        {
            CloseDoor();
        }
        else
        {
            OpenDoor();
        }

        isOpen = !isOpen;
    }

    private void OpenDoor()
    {
        doorClose.SetActive(false);
        doorOpen.SetActive(true);
        Debug.Log("Pintu dibuka");
    }

    private void CloseDoor()
    {
        doorClose.SetActive(true);
        doorOpen.SetActive(false);
        Debug.Log("Pintu ditutup");
    }
}
