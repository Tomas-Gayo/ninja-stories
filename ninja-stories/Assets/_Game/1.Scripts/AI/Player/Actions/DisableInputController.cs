using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "DisableInputController", menuName = "Scriptable Objects/FSM/Player/Actions/DisableInputController")]
public class DisableInputController : FSMAction
{
    [SerializeField] private InputReader inputReader;

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        inputReader.DisableAllInputs();
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }

    public override void OnUpdate(BaseStateMachine stateMachine) { }
}
