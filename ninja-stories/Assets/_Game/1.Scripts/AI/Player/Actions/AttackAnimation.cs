using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "AttackAnimation", menuName = "Scriptable Objects/FSM/Player/Actions/AttackAnimation")]
public class AttackAnimation : FSMAction
{
    [SerializeField] private CharacterAnimatorParamSO animParamSO;

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        Animator animator = stateMachine.GetComponent<Animator>();

        animator.SetTrigger(animParamSO.AttackParamName);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }

    public override void OnUpdate(BaseStateMachine stateMachine) { }
}
