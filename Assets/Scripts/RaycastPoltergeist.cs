
using UnityEngine;

public class RaycastPoltergeist : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform RaySource;
    public LayerMask playerMask;
    private bool triggered;


    void Start()
    {
        RaySource = GetComponent<Transform>();
        triggered = false;
    }


    void Update()
    {
        Debug.DrawRay(RaySource.position, RaySource.forward, Color.red);


        if (!triggered && Physics.Raycast(RaySource.position, RaySource.forward, out RaycastHit hitInfo, 1f, playerMask))
        {
            if (hitInfo.collider.CompareTag("Player")){
                ITriggerPolt poltergeist = GetComponent<ITriggerPolt>();
                if (poltergeist != null)
                {
                    poltergeist.triggerPolt();
                    Debug.Log("Hit Player");
                    triggered = true;
                }
            }
        }
        
    }
}
