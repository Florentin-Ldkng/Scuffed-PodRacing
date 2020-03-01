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
        Debug.Log("Load Scene Again!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /// <summary>
    /// Function for the "BackToStartMenuButton." Loads the Start Menu
    /// </summary>
    public void BackToStartMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
