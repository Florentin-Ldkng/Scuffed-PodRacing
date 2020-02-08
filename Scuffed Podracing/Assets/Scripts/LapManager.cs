using UnityEngine;

public class LapManager : MonoBehaviour
{
    public bool Checkpoint1;
    public bool Checkpoint2;
    public bool Checkpoint3;
    public bool Checkpoint4;
    public GameObject GameManager;


    public void StartLap()
    {
        if (Checkpoint1 && Checkpoint2 && Checkpoint3 && Checkpoint4)
        {
            Checkpoint1 = false;
            Checkpoint2 = false;
            Checkpoint3 = false;
            Checkpoint4 = false;
            var lapTime = GameManager.GetComponent<GameManager>();
            lapTime.GetLapTime();
        }
    }
}