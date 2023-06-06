using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "UnsheatheSheatheDecision", menuName = "Scriptable Objects/FSM/Player/Decisions/UnsheatheSheatheDecision")]
public class UnsheatheSheatheDecision : Decision
{
    public override bool Decide(BaseStateMachine stateMachine)
    {
        var character = stateMachine.GetComponent<PlayerAttack>();

        return character.SheatheUnsheathe;
    }
}
