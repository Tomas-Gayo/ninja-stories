using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IsTargetOnSight", menuName = "Scriptable Objects/FSM/Decisions/IsTargetOnSight")]
public class IsTargetOnSight : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        var NPC = stateMachine.GetComponent<NPCSightSensor>();

        return NPC.IsTargetInDetectionZone; ;
    }
}
