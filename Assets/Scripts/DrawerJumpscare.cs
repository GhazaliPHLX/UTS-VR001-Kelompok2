using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerJumpscare : MonoBehaviour, IInteractable
{
    private bool isOpen;
    private bool triggered;
    private Transform drawer;
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
            drawer.localPosition = new Vector3(0f, 0f, 0f);
            isOpen = true;
            ITriggerPolt poltergeist = GetComponent<ITriggerPolt>();
            if (poltergeist != null)
            {
                poltergeist.triggerPolt();
                Debug.Log("triggerPolt() berhasil dipanggil");
                triggered = true;
            }

        }
        else
        {
            drawer.localPosition = new Vector3(0.5f, 0f, 0f);
            isOpen = false;
        }
    }


}
