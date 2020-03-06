using System.Xml.Serialization;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool IsMoveable = false;
    public AudioSource EngineSource;

    void Update()
    {
        Movement();

    }

    public void Movement()
    {
        if (IsMoveable == true)
        {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 50.0f;

            transform.Rotate(0, x, 0);
            transform.Translate(0, 0, z);
            EngineSource.volume = 5f;
        }
        else
        {
            EngineSource.volume = 0f;
        }
    }
}