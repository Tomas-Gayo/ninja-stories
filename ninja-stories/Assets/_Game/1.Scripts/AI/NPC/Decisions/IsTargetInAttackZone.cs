using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IsTargetInAttackZone", menuName = "Scriptable Objects/FSM/Decisions/IsTargetInAttackZone")]
public class IsTargetInAttackZone : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        var NPC = stateMachine.GetComponent<NPCSightSensor>();

        return NPC.IsTargetInAttackZone;
    }
}
