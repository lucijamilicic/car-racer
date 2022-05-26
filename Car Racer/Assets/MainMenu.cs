using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Start() {
        Time.timeScale = 0f;
    }
    public void PlayGame() {
        Time.timeScale = 1f;
    }

    public void QuitGame() {
        Debug.Log("quit");
        Application.Quit();
    }
}

