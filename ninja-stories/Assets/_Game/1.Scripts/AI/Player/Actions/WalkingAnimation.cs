using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "WalkingAnimation", menuName = "Scriptable Objects/FSM/Player/Actions/WalkingAnimation")]
public class WalkingAnimation : FSMAction
{
    [SerializeField] private CharacterAnimatorParamSO animParamSO;

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        Animator animator = stateMachine.GetComponent<Animator>();

        animator.SetBool(animParamSO.RunParamName, false);
        animator.SetBool(animParamSO.IsMovingParamName, true);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }

    public override void OnUpdate(BaseStateMachine stateMachine) { }
}
