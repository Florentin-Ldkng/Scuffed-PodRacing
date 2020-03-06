using System.Xml.Serialization;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool IsMoveable = false;
    public float Speed = 0;
    private Vector3 _lastPosition = Vector3.zero;
    public AudioSource EngineSource;

    void Update()
    {
        Movement();
        Speed = (transform.position - _lastPosition).magnitude / Time.fixedDeltaTime;
        _lastPosition = transform.position;
        EngineSource.volume = Speed / 5;
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