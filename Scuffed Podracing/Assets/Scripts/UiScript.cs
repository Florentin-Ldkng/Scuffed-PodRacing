using UnityEngine;
using UnityEngine.UI;

public class UiScript : MonoBehaviour
{
    /// <summary>
    /// Healthbar Functionality, Hud Functionality
    /// Moritz Vogt
    /// </summary>
    public Text TimerText;
    public Text LapTime1Text;
    public Text LapTime2Text;
    public GameManager gameManager;
    public Health health;
    public Slider HealthBar;

    void Update()
    {
        HealthBar.value = health.TotalHealth;
        TimerText.text = gameManager.CountdownLength.ToString("f2");
        if (gameManager.CountdownLength <= 0)
        {
            TimerText.text = gameManager._lapTime.ToString("f2");
        }
        LapTime1Text.text = "Lap1: " + gameManager.Lap1.ToString("f2");
        LapTime2Text.text = "Lap2: " + gameManager.Lap2.ToString("f2");
        
    }
}
