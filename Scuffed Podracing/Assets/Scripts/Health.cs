using UnityEngine;

public class Health : MonoBehaviour
{
    public int TotalHealth = 100;

    public void getDamage(int amount)
    {
       TotalHealth -= amount;
    }

}
