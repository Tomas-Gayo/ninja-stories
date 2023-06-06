using UnityEngine;

/// <summary>
/// 
/// </summary>
public abstract class Decision : ScriptableObject
{
    public abstract bool Decide(BaseStateMachine stateMachine);
}
