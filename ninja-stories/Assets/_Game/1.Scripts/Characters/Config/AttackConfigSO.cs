using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "NewAttackConfig", menuName = "Scriptable Objects/Config/AttackConfig")]
public class AttackConfigSO : ScriptableObject
{
    [SerializeField] private int baseAttack;

    public int BaseAttack => baseAttack;
}
