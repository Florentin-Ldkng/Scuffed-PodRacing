using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    /// <summary>
    /// Kevin Keim
    /// </summary>
    private bool paused = false;
    public GameObject Hud;
    public GameObject pauseMenu;

    /// <summary>
    /// Triggers pause menu
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Continue();
                Hud.SetActive(true);
            }
            else
            {
                Pause();
                Hud.SetActive(false);
                
            }
        }
    }

    /// <summary>
    /// Method "Continue" for the function of the continue button
    /// </summary>
    public void Continue()
    {
        pauseMenu.SetActive(false);
        paused = false;
        Time.timeScale = 1f;
        Hud.SetActive(true);
    }

    /// <summary>
    /// Method Pause for pausing the game
    /// </summary>
    void Pause()
    {
        pauseMenu.SetActive(true);
        paused = true;
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
