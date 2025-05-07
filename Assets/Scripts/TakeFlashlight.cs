using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeFlashlight : MonoBehaviour
{
    public GameObject flashlight;
    public GameObject playerLight;

    public void takeFlashlight()
    {
        flashlight.SetActive(false);
        playerLight.SetActive(true);
    }
}
