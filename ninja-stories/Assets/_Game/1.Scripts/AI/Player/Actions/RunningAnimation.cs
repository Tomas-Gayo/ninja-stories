using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "RunningAnimation", menuName = "Scriptable Objects/FSM/Player/Actions/RunningAnimation")]
public class RunningAnimation : FSMAction
{
    [SerializeField] private CharacterAnimatorParamSO animParamSO;

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        Animator animator = stateMachine.GetComponent<Animator>();

        animator.SetBool(animParamSO.RunParamName, true);
        animator.SetBool(animParamSO.IsMovingParamName, true);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }

    public override void OnUpdate(BaseStateMachine stateMachine) { }
}
