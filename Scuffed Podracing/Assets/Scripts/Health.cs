using UnityEngine;

public class Health : MonoBehaviour
{
    public float TotalHealth = 100f;
    
    private void Start()
    {
        TotalHealth = 100f;
    }

    public void GetDamage(int amount)
    {
        TotalHealth -= amount;
    }

    public void ResetHealth()
    {
        TotalHealth = 100f;
    }
}