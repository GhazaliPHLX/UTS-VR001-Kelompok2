using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightScript : MonoBehaviour , IInteractable
{
    public GameObject UISenter;

    public void Interact()
    {
        UISenter.SetActive(true);
    }

}
