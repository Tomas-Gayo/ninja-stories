using UnityEngine;

/// <summary>
/// Save health data and adds some logic to the 
/// </summary>
[CreateAssetMenu(fileName = "NewHealthSO", menuName = "Scriptable Objects/HealthSO")]
public class HealthSO : ScriptableObject
{
    [Header("Configuration")]
    [SerializeField] private int maxHealth;
    [SerializeField] private int currentHealth;

    public int MaxHealth
    {
        get { return maxHealth; }
        set { maxHealth = value; }
    }

    public int CurrentHealth 
    {
        get 
        { 
            // Clamp 0 to Max
            if (currentHealth > maxHealth)
                currentHealth = maxHealth;

            if (currentHealth < 0)
                currentHealth = 0;

            return currentHealth; 
        
        }
        set { currentHealth = value; }
    }

    public float CurrentHealthNormalized
    {
        get 
        { 
            return (float)CurrentHealth / MaxHealth; 
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    public void RestoreHealth(int cure)
    {
        currentHealth += cure;
        Debug.Log($"Health is {currentHealth}");
        //if (currentHealth > maxHealth)
        //    currentHealth = maxHealth;        
    }
}
