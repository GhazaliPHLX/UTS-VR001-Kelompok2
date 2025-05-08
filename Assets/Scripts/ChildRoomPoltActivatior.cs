using UnityEngine;

public class RaycastPoltergeistChildRoom : MonoBehaviour
{
    private Transform RaySource;
    public LayerMask playerMask;
    private bool triggered;

    [Header("Target Script to Disable")]
    public GameObject targetObject; 
    public GameObject blockGameObject;

    void Start()
    {
        RaySource = GetComponent<Transform>();
        triggered = false;
    }

    void Update()
    {
        if (!triggered && Physics.Raycast(RaySource.position, RaySource.forward, out RaycastHit hitInfo, 3f, playerMask))
        {
            

                // Menonaktifkan script RaycastPoltergeist di GameObject target
                RaycastPoltergeist targetScript = targetObject.GetComponent<RaycastPoltergeist>();
                if (targetScript != null)
                {
                    targetScript.enabled = true;
                    triggered = true;
                    blockGameObject.SetActive(false);
                    Debug.Log("RaycastPoltergeist script di target diaktifkan.");
                }
                else
                {
                    Debug.LogWarning("Script RaycastPoltergeist tidak ditemukan di targetObject.");
                }
            
        }
    }
}
