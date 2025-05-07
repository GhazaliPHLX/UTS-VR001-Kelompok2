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
            StartCoroutine(ScreamAndDisable());
            AudioSource.PlayClipAtPoint(screamClip, transform.position);

            triggered = true;
        }
    }

    private IEnumerator ScreamAndDisable()
    {
        yield return new WaitForSeconds(0.5f);
        agatha.SetActive(false);
    }
}
