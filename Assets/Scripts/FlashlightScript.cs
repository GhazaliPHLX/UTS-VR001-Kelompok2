using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightScript : MonoBehaviour , IInteractable
{
    public GameObject flashlight;
    public GameObject playerLight;

    public void Interact()
    {
        flashlight.SetActive(false);
        playerLight.SetActive(true);
    }

}
