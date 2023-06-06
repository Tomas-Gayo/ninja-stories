using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IsCharacterGettingHit", menuName = "Scriptable Objects/FSM/Decisions/IsCharacterGettingHit")]
public class IsCharacterGettingHit : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        var NPC = stateMachine.GetComponent<Damageable>();

        return NPC.IsHit;
    }
}
