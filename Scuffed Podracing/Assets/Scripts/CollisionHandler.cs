using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject Respawner;
    public GameObject Start;
    public GameObject Checkpoint1;
    public GameObject Checkpoint2;
    public GameObject Checkpoint3;
    public GameObject Checkpoint4;
    public Rigidbody rb;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Map"))
        {
            Respawning();
        }
    }

    private void Respawning()
    {
        var respawnPositionCheck = Respawner.GetComponent<LapManager>();
        if (respawnPositionCheck.Checkpoint4)
        {
            transform.position = Checkpoint4.transform.position;
            transform.rotation = Checkpoint4.transform.rotation;
            RigidBodyZero();
        }
        else if (respawnPositionCheck.Checkpoint3)
        {
            transform.position = Checkpoint3.transform.position;
            transform.rotation = Checkpoint3.transform.rotation;
            RigidBodyZero();
        }
        else if (respawnPositionCheck.Checkpoint2)
        {
            transform.position = Checkpoint2.transform.position;
            transform.rotation = Checkpoint2.transform.rotation;
            RigidBodyZero();
        }
        else if (respawnPositionCheck.Checkpoint1)
        {
            transform.position = Checkpoint1.transform.position;
            transform.rotation = Checkpoint1.transform.rotation;
            RigidBodyZero();
        }
        else
        {
            transform.position = Start.transform.position;
            transform.rotation = Start.transform.rotation;
            RigidBodyZero();
        }
    }

    private void RigidBodyZero()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}