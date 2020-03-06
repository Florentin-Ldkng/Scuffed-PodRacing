using UnityEngine;

public class StartLap : MonoBehaviour
{
    /// <summary>
    /// sets the checkpoint of the player to the Spawn Checkpoint
    /// Florentin Lüdeking
    /// </summary>
    /// <param name="other">the collider</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var setCheckpoint = other.GetComponent<LapManager>();
            setCheckpoint.StartLap();
        }
    }
}
