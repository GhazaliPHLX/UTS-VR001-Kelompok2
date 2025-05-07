using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Game : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        LoadToScene("MainScene");
    }

    public void LoadToScene(string sceneName)
    {
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError($"Scene '{sceneName}' tidak ditemukan atau belum ditambahkan ke Build Settings!");
        }
    }
}
