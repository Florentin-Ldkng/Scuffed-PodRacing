using UnityEngine;

public class Checkpoint4 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var setCheckpoint = other.GetComponent<LapManager>();
            setCheckpoint.Checkpoint4 = true;
        }
    }
}
