using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    /// <summary>
    /// Play Button Function for starting the game.
    /// </summary>
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    /// <summary>
    /// Quit Button Function to exit the game.
    /// </summary>
    public void QuitGame()
    {
        Debug.Log("Quit the game!");
        Application.Quit();
    }
}
