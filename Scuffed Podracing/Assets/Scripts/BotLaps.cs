using UnityEngine;

public class BotLaps : MonoBehaviour
{
    /// <summary>
    /// Florentin Lüdeking
    /// Counts the Laps that the bots drove and stops the game if a bot drove 2 laps
    /// </summary>
    public int _lapCounter;
    public GameObject HUD;
    public GameObject LoseScreen;
    
    void Update()
    {
        if (_lapCounter >= 3)
        {
            LoseScreen.SetActive(true);
            Time.timeScale = 0f;
            HUD.SetActive(false);
        }   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Character"))
        {
            _lapCounter++;
        }
    }
}
