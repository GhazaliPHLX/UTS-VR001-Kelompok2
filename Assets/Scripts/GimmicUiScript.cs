using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GimmicUiScript : MonoBehaviour
{
    public GameObject UIGimic;
    public GameObject UIStuck;

    public void GimmicButton()
    {
        UIGimic.SetActive(false);
        UIStuck.SetActive(true);
    }
}
