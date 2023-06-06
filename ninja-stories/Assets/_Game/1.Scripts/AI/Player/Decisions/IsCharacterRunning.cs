using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IsCharacterRunning", menuName = "Scriptable Objects/FSM/Player/Decisions/IsCharacterRunning")]
public class IsCharacterRunning : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        var character = stateMachine.GetComponent<PlayerMovement>();

        if (character.IsRunning) return true;
        else return false;
    }
}
