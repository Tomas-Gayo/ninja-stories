using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IsCharacterAttacking", menuName = "Scriptable Objects/FSM/Player/Decisions/IsCharacterAttacking")]
public class IsCharacterAttacking : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        var character = stateMachine.GetComponent<PlayerAttack>();

        return character.HasAttacked;
    }
}
