using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IsCharacterDead", menuName = "Scriptable Objects/FSM/Decisions/IsCharacterDead")]
public class IsCharacterDead : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        var character = stateMachine.GetComponent<Damageable>();

        return character.IsDead;
    }
}
