using UnityEngine;

public class RaycastInteractor : MonoBehaviour
{
    public Transform hand;
    public float interactDistance = 1f;
    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        if (lineRenderer == null)
        {
            Debug.LogError("LineRenderer not found on the GameObject!");
            return;
        }

        lineRenderer.positionCount = 2;
        lineRenderer.enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Vector3 rayOrigin = hand.position;
            Vector3 rayDirection = hand.up;

            Ray ray = new Ray(rayOrigin, rayDirection);
            RaycastHit hit;
            Vector3 rayEnd = rayOrigin + rayDirection * interactDistance;

            if (Physics.Raycast(ray, out hit, interactDistance))
            {
                rayEnd = hit.point;

                var interactable = hit.collider.GetComponent<IInteractable>();
                if (interactable != null)
                {
                    interactable.Interact();
                }

                Debug.Log("Interacted with: " + hit.collider.name);
            }
            else
            {
                Debug.Log("Nothing to interact with");
            }

            // Ini penting: gunakan posisi world dari hand
            lineRenderer.enabled = true;
            lineRenderer.SetPosition(0, rayOrigin);
            lineRenderer.SetPosition(1, rayEnd);
        }
        else
        {
            lineRenderer.enabled = false;
        }
    }
}
