using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostScream : MonoBehaviour, ITrigger
{
    public AudioClip screamClip;
    private bool triggered;
    private GameObject agatha;

    private void Start()
    {
        agatha = gameObject;
        triggered = false;
    }

    public void trigger()
    {
        if (!triggered)
        {
            AudioSource.PlayClipAtPoint(screamClip, transform.position);
            agatha.SetActive(false);
            triggered = true;
        }
    }
}
