using UnityEngine;

public class LapManager : MonoBehaviour
{
    /// <summary>
    /// Florentin Lüdkeing im sry 3.0 ;-;
    /// The list of checkpoints. 
    /// Gets set true if the player crosses a checkpoint. 
    /// If the playe crosses the start all checkpoints get deactivated and the lap time gets saved
    /// </summary>
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