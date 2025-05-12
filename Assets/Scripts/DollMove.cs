using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollMove : MonoBehaviour, ITrigger
{
    private Transform wheelChair;
    public AudioClip dollAudio;
    private bool triggered;

    private void Start()
    {
        wheelChair = GetComponent<Transform>();
        triggered = false;

    }
    public void trigger()
    {
        if (!triggered)
        {
            AudioSource.PlayClipAtPoint(dollAudio, wheelChair.position);
            wheelChair.localPosition = new Vector3(-17.356f, 8.248f, 6.222f);
            wheelChair.localRotation = Quaternion.Euler(-87.664f, 2.649f, -185.629f);
            triggered = true;
        }
    }
}
