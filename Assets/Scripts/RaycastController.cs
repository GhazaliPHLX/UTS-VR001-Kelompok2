using UnityEngine;

public class RaycastInteractor : MonoBehaviour
{
    public Transform hand;
    public float interactDistance = 1f;
    private LineRenderer lineRenderer;

    private RaycastHit cachedHit;
    private bool hasHit = false;


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
            Vector3 rayEnd = rayOrigin + rayDirection * interactDistance;

            Ray ray = new Ray(rayOrigin, rayDirection);

            hasHit = Physics.Raycast(ray, out cachedHit, interactDistance);
            if (hasHit)
            {
                rayEnd = cachedHit.point;
            }

            // Gambar ray visual
            lineRenderer.enabled = true;
            lineRenderer.SetPosition(0, rayOrigin);
            lineRenderer.SetPosition(1, rayEnd);

            // Klik kiri untuk interaksi
            if (Input.GetMouseButtonDown(0))
            {
                if (hasHit)
                {
                    var interactable = cachedHit.collider.GetComponent<IInteractable>();
                    interactable?.Interact();
                    // Debug.Log("Interacted with: " + cachedHit.collider.name);
                }
                else
                {
                    Debug.Log("Nothing to interact with");
                }
            }
        }
        else
        {
            lineRenderer.enabled = false;
            hasHit = false;
        }
    }
}
