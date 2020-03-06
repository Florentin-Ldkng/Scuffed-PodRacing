using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// Florentin Lüdeking
    /// </summary>
    public bool IsMoveable = false;
    public float Speed = 0;
    public AudioSource EngineSource;
    private Vector3 _lastPosition = Vector3.zero;    

    /// <summary>
    /// Movement and getting the speed of the player and changing the volume of the engine according to the speed of the player
    /// </summary>
    void Update()
    {
        Movement();
        Speed = (transform.position - _lastPosition).magnitude / Time.fixedDeltaTime;
        _lastPosition = transform.position;
        EngineSource.volume = Speed /100;
    }

    public void Movement()
    {
        if (IsMoveable == true)
        {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 50.0f;

            transform.Rotate(0, x, 0);
            transform.Translate(0, 0, z);
        }
    }
}