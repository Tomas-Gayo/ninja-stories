using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IsCharacterMoving", menuName = "Scriptable Objects/FSM/Player/Decisions/IsCharacterMoving")]
public class IsCharacterMoving : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        var character = stateMachine.GetComponent<PlayerMovement>();

        if (character.MoveDirection.magnitude > 0.01f) return true;
        else return false;
    }
}
