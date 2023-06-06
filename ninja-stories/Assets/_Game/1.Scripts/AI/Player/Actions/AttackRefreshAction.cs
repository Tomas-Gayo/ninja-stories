using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "AttackRefreshAction", menuName = "Scriptable Objects/FSM/Player/Actions/AttackRefreshAction")]
public class AttackRefreshAction : FSMAction
{
    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        var character = stateMachine.GetComponent<PlayerAttack>();

        character.HasAttacked = false;
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }

    public override void OnUpdate(BaseStateMachine stateMachine) { }
}
