using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Game : MonoBehaviour, IInteractable
{
    [SerializeField] private Scene MainScene;
    public void Interact()
    {
        LoadToScene("MainScene");
    }

    public void LoadToScene(string MainScene)
    {
        SceneManager.LoadScene(MainScene);
    }
}