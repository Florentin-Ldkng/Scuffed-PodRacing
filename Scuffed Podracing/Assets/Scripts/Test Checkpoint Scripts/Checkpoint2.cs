using UnityEngine;

public class Checkpoint2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var setCheckpoint = other.GetComponent<LapManager>();
            setCheckpoint.Checkpoint2 = true;
        }
    }
}
