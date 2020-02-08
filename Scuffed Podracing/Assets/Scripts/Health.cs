using UnityEngine;

public class Health : MonoBehaviour
{
    public int TotalHealth = 100;

    public void GetDamage(int amount)
    {
        TotalHealth -= amount;
    }

    public void ResetHealth()
    {
        TotalHealth = 100;
    }
}