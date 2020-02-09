using UnityEngine;

public class Health : MonoBehaviour
{
    public float TotalHealth = 75f;

    private void Start()
    {
        TotalHealth = 50f;
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