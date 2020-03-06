using UnityEngine;

public class BotLaps : MonoBehaviour
{
    public int _lapCounter;

    public GameObject LoseScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_lapCounter >= 3)
        {
            LoseScreen.SetActive(true);
            Time.timeScale = 0f;
        }   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Character"))
        {
            _lapCounter++;
        }
    }
}
