using UnityEngine;

/// <summary>
/// 
/// </summary
public class BaseState : ScriptableObject
{
    public virtual void OnUpdate(BaseStateMachine stateMachine) { }
    public virtual void OnEnterState(BaseStateMachine stateMachine) { }
    public virtual void OnExitState(BaseStateMachine stateMachine) { }
}
