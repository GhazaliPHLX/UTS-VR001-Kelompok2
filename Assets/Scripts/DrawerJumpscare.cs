
using UnityEngine;

public class DrawerJumpscare : MonoBehaviour, IInteractable
{
    private bool isOpen;
    private bool triggered;
    private Transform drawer;
    public GameObject westRoomDoor;
    public GameObject wheelchair;
    public AudioClip doorclose;
    private void Start()
    {
        drawer = GetComponent<Transform>();
        isOpen = false;
        triggered = false;
        
    }
    public void Interact()
    {
        if (!isOpen)
        {
            drawer.localPosition = new Vector3(0.5f, 0f, 0f);
            isOpen = true;
            Debug.Log("Drawer dibuka");
            ITriggerPolt poltergeist = GetComponent<ITriggerPolt>();
                if (!triggered && poltergeist != null)
                {
                    poltergeist.triggerPolt();
                    CloseDoor doorScript = westRoomDoor.GetComponent<CloseDoor>();
                    if (doorScript != null)
                    {
                        doorScript.Interact();
                        AudioSource.PlayClipAtPoint(doorclose, westRoomDoor.transform.position);

                        Debug.Log("DoorClosed");
                        DollMove dollMove = wheelchair.GetComponent<DollMove>();
                        if (dollMove != null)
                        {
                            dollMove.enabled = true;
                            Debug.Log("Script DollMove berhasil diaktifkan.");
                        }
                        Collider wcCollider = wheelchair.GetComponent<Collider>();
                        if (wcCollider != null)
                        {
                            wcCollider.enabled = true;
                            Debug.Log("Collider wheelchair diaktifkan.");
                        }
                }
                triggered = true;
                }
                
            

        }
        else
        {
            drawer.localPosition = new Vector3(0f, 0f, 0f);
            isOpen = false;
        }
    }


}
