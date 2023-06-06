using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IsTargetInAlertZone", menuName = "Scriptable Objects/FSM/Decisions/IsTargetInAlertZone")]
public class IsTargetInAlertZone : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        var NPC = stateMachine.GetComponent<NPCSightSensor>();

        return NPC.IsTargetInAlertZone;
    }
}
