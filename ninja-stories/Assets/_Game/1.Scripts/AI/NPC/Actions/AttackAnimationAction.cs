using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "AttackAnimationAction", menuName = "Scriptable Objects/FSM/Actions/AttackAnimationAction")]
public class AttackAnimationAction : FSMAction
{
    [SerializeField] private CharacterAnimatorParamSO animParamSO;
    public override void OnUpdate(BaseStateMachine stateMachine) { }

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        Animator animator = stateMachine.GetComponent<Animator>();

        // Play animations
        animator.SetTrigger(animParamSO.AttackParamName);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }
}
