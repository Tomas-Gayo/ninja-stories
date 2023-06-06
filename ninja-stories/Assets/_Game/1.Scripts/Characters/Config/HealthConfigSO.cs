using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "NewHealthConfig", menuName = "Scriptable Objects/Config/ConfigHealthSO")]
public class HealthConfigSO : ScriptableObject
{
    [SerializeField, Tooltip("Base health of the character")]
    private int baseHealth;

    public int BaseHealth => baseHealth;
}
