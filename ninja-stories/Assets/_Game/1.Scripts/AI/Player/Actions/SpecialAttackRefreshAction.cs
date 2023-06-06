using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "SpecialAttackRefreshAction", menuName = "Scriptable Objects/FSM/Player/Actions/SpecialAttackRefreshAction")]
public class SpecialAttackRefreshAction : FSMAction
{
    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        var character = stateMachine.GetComponent<PlayerAttack>();

        character.HasSpecialAttacked = false;
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }

    public override void OnUpdate(BaseStateMachine stateMachine) { }
}
