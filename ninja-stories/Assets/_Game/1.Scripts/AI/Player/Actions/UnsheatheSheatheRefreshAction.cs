using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "UnsheatheSheatheRefreshAction", menuName = "Scriptable Objects/FSM/Player/Actions/UnsheatheSheatheRefreshAction")]
public class UnsheatheSheatheRefreshAction : FSMAction
{
    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        var character = stateMachine.GetComponent<PlayerAttack>();

        character.SheatheUnsheathe = false;
    }

    public override void OnExitState(BaseStateMachine stateMachine)
    {

    }

    public override void OnUpdate(BaseStateMachine stateMachine)
    {

    }
}
