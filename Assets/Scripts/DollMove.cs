using System.Collections;
using UnityEngine;

public class DollMove : MonoBehaviour, ITrigger
{
    private Transform wheelChair;
    private Collider wcCollider;
    public AudioClip dollAudio;
    private bool triggered;

    private void Start()
    {
        wheelChair = GetComponent<Transform>();
        wcCollider = wheelChair.GetComponent<Collider>();
        triggered = false;
    }

    public void trigger()
    {
        if (!triggered)
        {
            AudioSource.PlayClipAtPoint(dollAudio, wheelChair.position);
            StartCoroutine(MoveAfterDelay());
            triggered = true;
        }
    }

    private IEnumerator MoveAfterDelay()
    {
        yield return new WaitForSeconds(0.5f);
        wheelChair.localPosition = new Vector3(-17.356f, 8.248f, 6.222f);
        wheelChair.localRotation = Quaternion.Euler(-87.664f, 2.649f, -185.629f);
        wcCollider.enabled = false;
        
    }
}
