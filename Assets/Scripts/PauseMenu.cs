using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuObj, optionsMenuObj;
    public SC_FPSController player;
    public bool paused;
    public string menuSceneName;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            paused = !paused;
            if (paused == true)
            {
                player.enabled = false;
                pauseMenuObj.SetActive(true);
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                AudioListener.pause = true;
            }
            if (paused == false)
            {
                player.enabled = true;
                optionsMenuObj.SetActive(false);
                pauseMenuObj.SetActive(false);
                Time.timeScale = 1f;
                Cursor.lockState = CursorLockMode.Locked;
                AudioListener.pause = false;
            }
        }
    }

    public void resumeGame()
    {
        player.enabled = true;
        pauseMenuObj.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;  
        AudioListener.pause = false;
        paused = false;
    }

    public void openOptions()
    {
        pauseMenuObj.SetActive(false);
        optionsMenuObj.SetActive(true);
    }

    public void goBack()
    {
        pauseMenuObj.SetActive(true);
        optionsMenuObj.SetActive(false);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene(menuSceneName);
    }

    public void quitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
