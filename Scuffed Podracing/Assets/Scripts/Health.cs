using UnityEngine;

public class Health : MonoBehaviour
{
    /// <summary>
    /// Florentin Lüdeking
    /// Health Managment 
    /// </summary>
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