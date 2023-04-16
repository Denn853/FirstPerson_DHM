using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string gameSceneName;

    public void returnToMainMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(gameSceneName);
    }
}
