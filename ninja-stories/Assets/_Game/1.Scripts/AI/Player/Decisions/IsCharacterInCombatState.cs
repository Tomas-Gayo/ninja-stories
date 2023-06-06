using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IsCharacterInCombatState", menuName = "Scriptable Objects/FSM/Player/Decisions/IsCharacterInCombatState")]
public class IsCharacterInCombatState : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        var character = stateMachine.GetComponent<PlayerAttack>();

        return character.InCombatState;
    }
}
