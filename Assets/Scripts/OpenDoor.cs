using UnityEngine;

public class DoorScript1 : MonoBehaviour, IInteractable
{
    public GameObject doorOpen;
    public GameObject doorClose;

    

    public virtual void Interact()
    {
        OpenDoor(); 
    }

    private void OpenDoor()
    {
        doorClose.SetActive(false);
        doorOpen.SetActive(true);
    }

}
