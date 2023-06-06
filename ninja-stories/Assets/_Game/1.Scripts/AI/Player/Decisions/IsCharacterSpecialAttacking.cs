using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IsCharacterSpecialAttacking", menuName = "Scriptable Objects/FSM/Player/Decisions/IsCharacterSpecialAttacking")]
public class IsCharacterSpecialAttacking : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        var character = stateMachine.GetComponent<PlayerAttack>();

        return character.HasSpecialAttacked;
    }
}
