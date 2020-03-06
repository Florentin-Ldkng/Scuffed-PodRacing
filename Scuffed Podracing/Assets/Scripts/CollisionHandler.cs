using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    /// <summary>
    /// Florentin Lüdeking im sry 2.0 ;-;
    /// </summary>
    public GameObject Respawner;
    public GameObject Start;
    public GameObject Checkpoint1;
    public GameObject Checkpoint2;
    public GameObject Checkpoint3;
    public GameObject Checkpoint4;
    public GameObject LoseScreen;
    public Health Health;
    public Rigidbody RB;
    public GameObject Hud;
    private AudioSource _audioSource;

    /// <summary>
    /// if the player crashes into the map or an enemy he respawns and loses health
    /// </summary>
    /// <param name="other"></param>
    void OnCollisionEnter(Collision other)
    {
       if (other.gameObject.CompareTag("Map"))
        {
            _audioSource = GetComponent<AudioSource>();
            _audioSource.Play(0);
            Health.GetDamage(25);
            if (Health.TotalHealth <= 0f)
            {
                LoseScreen.SetActive(true);
                Time.timeScale = 0;
                Hud.SetActive(false);
            }
            

            Respawning();
        }
        else
        {
            _audioSource = GetComponent<AudioSource>();
            _audioSource.Play(0);
            Health.GetDamage(25);
            if (Health.TotalHealth <= 0f)
            {
                LoseScreen.SetActive(true);
                Time.timeScale = 0;
            }
            Respawning();
        } 
    }

    /// <summary>
    /// The respawning function so the player spawns at the last checkpoint he crossed
    /// </summary>
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

    /// <summary>
    /// zeros out the rigidbody 
    /// </summary>
    private void RigidBodyZero()
    {
        RB.velocity = Vector3.zero;
        RB.angularVelocity = Vector3.zero;
    }
}