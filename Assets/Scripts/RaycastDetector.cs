using UnityEngine;

public class RaycastDetector : MonoBehaviour
{
    public float interactDistance = 5f;
    private RaycastHit cachedHit;
    private bool hasHit = false;
    private ITrigger lastTarget = null;

    void Update()
    {
        Vector3 rayOrigin = transform.position;
        Vector3 rayDirection = transform.forward;

        Ray ray = new Ray(rayOrigin, rayDirection);
        hasHit = Physics.Raycast(ray, out cachedHit, interactDistance);

        if (hasHit && cachedHit.collider != null)
        {
            ITrigger target = cachedHit.collider.GetComponent<ITrigger>();

            if (target != null && target != lastTarget)
            {
                target.trigger();
                Debug.Log("Triggered object: " + cachedHit.collider.name);
                lastTarget = target;
            }
        }
        else
        {
            lastTarget = null;
        }
    }

}
