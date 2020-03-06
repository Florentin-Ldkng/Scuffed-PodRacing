using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// Florentin Lüdeking Im sry ;-; 
    /// Funktionality 1: Timer and Countdown
    /// Funktionality 2: Sets the lap time in the win screen
    /// Funktionality 3: Setting movable after countdown
    /// Funktionality 4: Activating win screen after 2 finished laps
    /// </summary>
    private float _startTime;
    public float _lapTime;
    private bool _startCountdown;
    public bool _startTimer;
    private bool _lapped = false;
    public float CountdownLength = 5.0f;
    public float Lap1;
    public float Lap2;
    public GameObject Player;
    public GameObject WinScreen;
    public GameObject HUD;
    public Text Laps;


    void Start()
    {
        StartCountDown();
    }

    void Update()
    {
        Timer();
    }

    public void StartCountDown()
    {
        _startCountdown = true;
    }
    //Funktionality 4 + 2
    public void GetLapTime()
    {
        if (_lapped == true)
        {
            Lap2 = _lapTime - Lap1;
            HUD.SetActive(false);
            WinScreen.SetActive(true);
            Time.timeScale = 0.25f;
            Laps.text = "Lap 1: " + Lap1.ToString("F2") + "\nLap 2: " + Lap2.ToString("F2");
        }

        if (_lapped == false)
        {
            Lap1 = _lapTime;
            _lapped = true;
        }
    }

    //Funktionality 1 + 3
    private void Timer()
    {
        if (_startCountdown == true)
        {
            CountdownLength -= Time.deltaTime;
            if (CountdownLength <= 0)
            {
                _startCountdown = false;
                _startTimer = true;
                _startTime = Time.time;
                var movement = Player.GetComponent<PlayerController>();
                movement.IsMoveable = true;
            }
        }

        if (_startTimer == true)
        {
            _lapTime = Time.time - _startTime;
        }
    }
}