using UnityEngine;

public class UISpawn : MonoBehaviour
{
    [Tooltip("Drag semua UI yang terkait ke sini. Urutkan dari yang pertama muncul.")]
    public GameObject[] UIObjects;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && UIObjects.Length > 0)
        {
            // Hanya aktifkan UI pertama saat masuk
            UIObjects[0].SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Matikan semua UI terkait
            foreach (var ui in UIObjects)
            {
                if (ui != null)
                    ui.SetActive(false);
            }
        }
    }
}
