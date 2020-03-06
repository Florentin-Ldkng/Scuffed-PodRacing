using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool Paused = false;

    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Continue();
            }
            else
            {
                Pause();
            }
        }
    }

    /// <summary>
    /// Method "Continue" for the function of the continue button
    /// </summary>
    public void Continue()
    {
        pauseMenu.SetActive(false);
        Paused = false;
        Time.timeScale = 1f;
    }

    /// <summary>
    /// Method Pause for pausing the game
    /// </summary>
    void Pause()
    {
        pauseMenu.SetActive(true);
        Paused = true;
        Time.timeScale = 0f;
    }

    /// <summary>
    /// Function for the "Back to Start Menu Button"
    /// </summary>
    public void BackToStartMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

}
