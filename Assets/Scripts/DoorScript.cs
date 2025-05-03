using UnityEngine;

public class DoorScript : MonoBehaviour, IInteractable
{
    public GameObject doorOpen;
    public GameObject doorClose;

    private bool isOpen = false;

    public virtual void Interact()
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
    }

    private void CloseDoor()
    {
        doorClose.SetActive(true);
        doorOpen.SetActive(false);
    }
}
