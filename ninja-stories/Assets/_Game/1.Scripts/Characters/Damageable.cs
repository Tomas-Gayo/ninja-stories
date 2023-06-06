using UnityEngine;
using UnityEngine.Events;
using ScriptableObjectArchitecture;


/// <summary>
/// From this component the characters communicates the health state
/// </summary>
[RequireComponent(typeof(Animator))]
public class Damageable : MonoBehaviour
{
    [Header("Configuration")]
	[SerializeField] private HealthConfigSO healthConfingSO;
	[SerializeField] private HealthSO healthSO;

    [Header("Broadcasting on channels")]
	[SerializeField] private HealthSOGameEvent refreshHealthUI;
    [SerializeField] private UnityEvent onDeadEvent = default;


    public bool IsHit { get; set; }
    public bool IsDead { get; private set; }

    // Dependencies
    Ragdoll ragdoll;

    private void Awake()
    {
        if (healthSO == null)
        {
            healthSO = ScriptableObject.CreateInstance<HealthSO>();
            healthSO.MaxHealth = healthConfingSO.BaseHealth;
            healthSO.CurrentHealth = healthConfingSO.BaseHealth;
        }

        ragdoll = GetComponent<Ragdoll>();
    }


    public void ReceiveDamage(int damage)
    {
        if (IsDead || IsHit)
            return;

        IsHit = true;

        healthSO.TakeDamage(damage);

        refreshHealthUI?.Raise(healthSO);

        if (healthSO.CurrentHealth <= 0)
        {
            IsDead = true;
            ragdoll.ActivateRagdoll();
            onDeadEvent.Invoke();
        }
    }

    public void Cure(int restoreValue)
    {
        healthSO.RestoreHealth(restoreValue);

        refreshHealthUI?.Raise(healthSO);
    }


    public void Kill()
    {
        ReceiveDamage(healthSO.CurrentHealth);
    }

    public void Revive()
    {
        Cure(healthSO.MaxHealth);
        refreshHealthUI?.Raise(healthSO);

        IsDead = false;
    }

    #region Context Menu - Test
    [ContextMenu("Hit - Damage by 20")]
    void Editor20Hit()
    {
        ReceiveDamage(20);
    }

    [ContextMenu("Hit - Damage by 50")]
    void Editor50Hit()
    {
        ReceiveDamage(50);
    }

    [ContextMenu("Revive")]
    void EditorRevive()
    {
        Revive();
    }

    [ContextMenu("Kill")]
    void EditorKill()
    {
        Kill();
    }
    #endregion
}
