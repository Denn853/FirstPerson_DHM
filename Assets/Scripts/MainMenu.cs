using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu, options, extras, credits, dificulty, loading;
    public string gameSceneName;

    public void openOptions()
    {
        menu.SetActive(false);
        options.SetActive(true);
    }

    public void openExtras()
    {
        menu.SetActive(false);
        extras.SetActive(true);
    }

    public void openCredits()
    {
        menu.SetActive(false);
        credits.SetActive(true);
    }

    public void goBack()
    {
        options.SetActive(false);
        extras.SetActive(false);
        credits.SetActive(false);
        dificulty.SetActive(false);
        menu.SetActive(true);
    }

    public void quitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void playGame()
    {
        menu.SetActive(false);
        dificulty.SetActive(true);
    }

    public void veryHard()
    {
        PlayerPrefs.SetInt("dificulty", 0);
        PlayerPrefs.Save();
        dificulty.SetActive(false);
        loading.SetActive(true);
        SceneManager.LoadScene(gameSceneName);
    }

    public void Hard()
    {
        PlayerPrefs.SetInt("dificulty", 1);
        PlayerPrefs.Save();
        dificulty.SetActive(false);
        loading.SetActive(true);
        SceneManager.LoadScene(gameSceneName);
    }

    public void Medium()
    {
        PlayerPrefs.SetInt("dificulty", 2);
        PlayerPrefs.Save();
        dificulty.SetActive(false);
        loading.SetActive(true);
        SceneManager.LoadScene(gameSceneName);
    }

    public void Easy()
    {
        PlayerPrefs.SetInt("dificulty", 3);
        PlayerPrefs.Save();
        dificulty.SetActive(false);
        loading.SetActive(true);
        SceneManager.LoadScene(gameSceneName);
    }
}