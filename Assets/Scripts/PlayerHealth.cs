using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    void Start()
    {
        ResetHealth();
    }
    
    public void ResetHealth()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        if(currentHealth > 0)
            currentHealth -= amount * Time.deltaTime;
        
        if(currentHealth <= 0)
            currentHealth = 0;
    }

    public void Heal(float amount)
    {
        if(currentHealth > 100)
            currentHealth += amount * Time.deltaTime;
        
        if(currentHealth <= 100)
            currentHealth = 100;
    }

    public float GetCurrentHealth() => currentHealth;
}
