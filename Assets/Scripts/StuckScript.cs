using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuckScript : MonoBehaviour
{
    public GameObject stuckUI;

    public void OkButton()
    {
        stuckUI.SetActive(false);
    }
}
