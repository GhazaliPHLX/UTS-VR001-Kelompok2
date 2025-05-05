using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletInteract : MonoBehaviour, IInteractable
{
    private bool isOpen;
    private Transform closet;
    public void Interact()
    {
        closet = GetComponent<Transform>();
        if (closet != null && !isOpen)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);
            isOpen = true;
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            isOpen = false;
        }
        }

    private void Start()
    {
        isOpen = false;
    }
}
