using UnityEngine;

public class ContinueMusic : MonoBehaviour
{
    /// <summary>
    /// Making the Music play all the time (also in different scenes)
    /// Kevin Keim
    /// </summary>
    private static ContinueMusic instance = null;

    public static ContinueMusic Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject); 
    }
}
