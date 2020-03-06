using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    /// <summary>
    /// Function for "TryAgainButton" to start the game again
    /// </summary>
    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    /// <summary>
    /// Function for the "BackToStartMenuButton." Loads the Start Menu
    /// </summary>
    public void BackToStartMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1f;
    }

    /// <summary>
    /// Function for "BackToStartMenuButton"(Buildindex 2).
    /// </summary>
    public void BackToStartMenuTwo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        Time.timeScale = 1f;
    }
}
