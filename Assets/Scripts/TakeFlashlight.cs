using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeFlashlight : MonoBehaviour
{
    public GameObject flashlight;
    public GameObject playerLight;
    public GameObject ArrowSign0;
    public GameObject ArrowSign1;

    public void takeFlashlight()
    {
        flashlight.SetActive(false);
        playerLight.SetActive(true);
        ArrowSign0.SetActive(false);
        ArrowSign1.SetActive(false);
    }
}
