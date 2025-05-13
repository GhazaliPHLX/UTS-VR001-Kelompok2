using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomJumpscare : MonoBehaviour, ITriggerPolt
{
    public GameObject doorObject;
    public Light flashlight;
    public float blinkInterval = 0.2f;
    public float blinkDuration = 3f;
    public AudioClip doorclose;

    public void triggerPolt()
    {
        IInteractable interactable = doorObject.GetComponent<IInteractable>();
        if (interactable != null)
        {
            interactable.Interact();
        }
        else
        {
            Debug.LogWarning("GameObject pintu tidak memiliki komponen IInteractable.");
        }

        // Mulai coroutine untuk berkedip
        if (flashlight != null)
        {
            StartCoroutine(BlinkFlashlight());
        }
        else
        {
            Debug.LogWarning("Lampu senter belum diset.");
        }
        AudioSource.PlayClipAtPoint(doorclose, doorObject.transform.position);
    }

    private IEnumerator BlinkFlashlight()
    {
        float elapsed = 0f;
        bool isOn = flashlight.enabled;

        while (elapsed < blinkDuration)
        {
            flashlight.enabled = !flashlight.enabled;
            yield return new WaitForSeconds(blinkInterval);
            elapsed += blinkInterval;
        }

        
        flashlight.enabled = isOn;
    }
}

