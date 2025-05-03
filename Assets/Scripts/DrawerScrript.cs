using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerScrript : MonoBehaviour, IInteractable
{
    private bool isOpen;
    private Transform drawer;
    private void Start()
    {
        drawer = GetComponent<Transform>();
        isOpen = false;
    }
    public void Interact()
    {
        if (!isOpen)
        {   drawer.localPosition = new Vector3(0f, 0f, 0f);
            isOpen = true;
        }
        else
        {
            drawer.localPosition = new Vector3(0.5f, 0f, 0f);
            isOpen = false;
        }
    }

    
}
