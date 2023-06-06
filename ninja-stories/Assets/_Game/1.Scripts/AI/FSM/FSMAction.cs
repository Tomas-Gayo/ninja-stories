using UnityEngine;

/// <summary>
/// 
/// </summary>
public abstract class FSMAction : ScriptableObject
{
    public abstract void OnUpdate(BaseStateMachine stateMachine);
    public abstract void OnEnterState(BaseStateMachine stateMachine);
    public abstract void OnExitState(BaseStateMachine stateMachine);
}
