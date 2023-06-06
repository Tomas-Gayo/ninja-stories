using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IsTargetDead", menuName = "Scriptable Objects/FSM/Decisions/IsTargetDead")]
public class IsTargetDead : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        return true;
    }
}
