using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "StopMovementAnimation", menuName = "Scriptable Objects/FSM/Player/Actions/StopMovementAnimation")]
public class StopMovementAnimation : FSMAction
{
    [SerializeField] private CharacterAnimatorParamSO animParamSO;
    Animator animator;

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        animator = stateMachine.GetComponent<Animator>();


        animator.SetBool(animParamSO.RunParamName, false);
        animator.SetBool(animParamSO.IsMovingParamName, false);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }

    public override void OnUpdate(BaseStateMachine stateMachine) { }
}
