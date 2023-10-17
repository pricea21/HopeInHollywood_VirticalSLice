using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instructions : MonoBehaviour
{
    public GameObject instructionsUI;
    public GameObject[] GameUI;
    public GameObject pauseMenu;
    public GameObject startButton;
    public GameObject settingsButton;
    public static bool GameIsPaused = false;

    void Update()
    {
        
    }
    public void Exit()
    {

        instructionsUI.SetActive(false);
        startButton.SetActive(true);
        settingsButton.SetActive(true);
    }

    public void VolumeControl()
    {
        instructionsUI.SetActive(false);
        startButton.SetActive(false);
        settingsButton.SetActive(true);
        pauseMenu.SetActive(true);
    }

    public void SettingsButton()
    {
        instructionsUI.SetActive(true);
    }
}

