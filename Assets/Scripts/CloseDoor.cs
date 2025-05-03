using UnityEngine;

public class CloseDoor : MonoBehaviour, IInteractable
{
    public GameObject doorOpen;
    public GameObject doorClose;

    

    public virtual void Interact()
    {
        CloseTheDoor(); 
    }

    private void CloseTheDoor()
    {
        doorClose.SetActive(true);
        doorOpen.SetActive(false);
    }

}
