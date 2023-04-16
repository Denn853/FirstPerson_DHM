using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    public TMP_Dropdown graphicsDropdown, resolutionDropdown;
    public Slider volumeSlider, sensitivitySlider;
    public SC_FPSController player;

    void Start()
    {
        if (!PlayerPrefs.HasKey("gameLaunched"))
        {
            PlayerPrefs.SetInt("graphics", 0);
            PlayerPrefs.SetInt("screenResolution", 0);
            PlayerPrefs.SetInt("masterVolume", 1);
            PlayerPrefs.SetInt("mouseSensitivity", 3);
            PlayerPrefs.SetInt("gameLaunched", 0);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.HasKey("gameLaunched"))
        {
            graphicsDropdown.value = PlayerPrefs.GetInt("graphics");
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("graphics"));

            resolutionDropdown.value = PlayerPrefs.GetInt("screenResolution");
            if (PlayerPrefs.GetInt("screenResolution", 0) == 0)
            {
                Screen.SetResolution(3840, 2160, true);
            }
            if (PlayerPrefs.GetInt("screenResolution", 1) == 1)
            {
                Screen.SetResolution(2560, 1440, true);
            }
            if (PlayerPrefs.GetInt("screenResolution", 2) == 2)
            {
                Screen.SetResolution(1920, 1080, true);
            }
            if (PlayerPrefs.GetInt("screenResolution", 3) == 3)
            {
                Screen.SetResolution(1280, 720, true);
            }
            if (PlayerPrefs.GetInt("screenResolution", 4) == 4)
            {
                Screen.SetResolution(854, 480, true);
            }

            volumeSlider.value = PlayerPrefs.GetFloat("masterVolume");
            AudioListener.volume = PlayerPrefs.GetFloat("masterVolume");

            sensitivitySlider.value = PlayerPrefs.GetFloat("mouseSensivity");
            player.lookSpeed = PlayerPrefs.GetFloat("mouseSensivity");
        }
    }

    public void setGraphics()
    {
        PlayerPrefs.SetInt("graphics", graphicsDropdown.value);
        PlayerPrefs.Save();
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("graphics"));
    }

    public void setResolution()
    {
        PlayerPrefs.SetInt("screenResolution", resolutionDropdown.value);
        PlayerPrefs.Save();
        
        if (PlayerPrefs.GetInt("screenResolution", 0) == 0)
        {
            Screen.SetResolution(3840, 2160, true);
        }
        if (PlayerPrefs.GetInt("screenResolution", 1) == 1)
        {
            Screen.SetResolution(2560, 1440, true);
        }
        if (PlayerPrefs.GetInt("screenResolution", 2) == 2)
        {
            Screen.SetResolution(1920, 1080, true);
        }
        if (PlayerPrefs.GetInt("screenResolution", 3) == 3)
        {
            Screen.SetResolution(1280, 720, true);
        }
        if (PlayerPrefs.GetInt("screenResolution", 4) == 4)
        {
            Screen.SetResolution(854, 480, true);
        }
    }

    public void setVolume() 
    {
        PlayerPrefs.SetFloat("masterVolume", volumeSlider.value);
        PlayerPrefs.Save();
        AudioListener.volume = PlayerPrefs.GetFloat("masterVolume");
    }
    public void setSensitivity()
    {
        PlayerPrefs.SetFloat("mouseSensivility", sensitivitySlider.value);
        PlayerPrefs.Save();
        player.lookSpeed = PlayerPrefs.GetFloat("mouseSensivity");
    }
}
