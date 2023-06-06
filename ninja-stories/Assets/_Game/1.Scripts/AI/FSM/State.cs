using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "State", menuName = "Scriptable Objects/FSM/State")]
public sealed class State : BaseState
{
    public List<FSMAction> Action = new List<FSMAction>();
    public List<Transition> Transition = new List<Transition>();


    public override void OnUpdate(BaseStateMachine stateMachine)
    {
        foreach(var action in Action)
            action.OnUpdate(stateMachine);

        foreach(var transition in Transition)
            transition.OnUpdate(stateMachine);
    }
    public override void OnEnterState(BaseStateMachine stateMachine) 
    {
        foreach (var action in Action)
            action.OnEnterState(stateMachine); ;
    }

    public override void OnExitState(BaseStateMachine stateMachine)
    {
        foreach (var action in Action)
            action.OnExitState(stateMachine); ;
    }
}
