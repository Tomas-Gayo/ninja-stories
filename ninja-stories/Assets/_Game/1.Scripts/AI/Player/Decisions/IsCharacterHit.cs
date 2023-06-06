using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IsCharacterHit", menuName = "Scriptable Objects/FSM/Player/Decisions/IsCharacterHit")]
public class IsCharacterHit : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        var character = stateMachine.GetComponent<Damageable>();

        return character.IsHit;
    }
}
