using UnityEngine;

public class GameManager : MonoBehaviour
{
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

    public void GetLapTime()
    {
        if (_lapped == true)
        {
            Lap2 = _lapTime - Lap1;
            //Debug.Log(Mathf.RoundToInt(Lap2)); //Repleace this Debug with a hud change
            HUD.SetActive(false);
            WinScreen.SetActive(true);
            Time.timeScale = 0.25f;

        }

        if (_lapped == false)
        {
            Lap1 = _lapTime;
            //Debug.Log(Mathf.RoundToInt(Lap1)); //Repleace this Debug with a hud change
            _lapped = true;
        }
    }


    private void Timer()
    {
        if (_startCountdown == true)
        {
            CountdownLength -= Time.deltaTime;
            //Debug.Log(Mathf.RoundToInt(CountdownLength)); //Replace the debugs with hud changes
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