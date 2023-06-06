using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "GetHitRefreshAction", menuName = "Scriptable Objects/FSM/Actions/GetHitRefreshAction")]
public class GetHitRefreshAction : FSMAction
{

    public override void OnUpdate(BaseStateMachine stateMachine)
    {
        
    }
    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        var character = stateMachine.GetComponent<Damageable>();

        character.IsHit = false;
    }

    public override void OnExitState(BaseStateMachine stateMachine)
    {

    }
}
