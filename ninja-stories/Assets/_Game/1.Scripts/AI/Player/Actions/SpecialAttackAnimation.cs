using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "SpecialAttackAnimation", menuName = "Scriptable Objects/FSM/Player/Actions/SpecialAttackAnimation")]
public class SpecialAttackAnimation : FSMAction
{
    [SerializeField] private CharacterAnimatorParamSO animParamSO;

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        Animator animator = stateMachine.GetComponent<Animator>();

        animator.SetTrigger(animParamSO.SpecialAttackParamName);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }

    public override void OnUpdate(BaseStateMachine stateMachine) { }
}
