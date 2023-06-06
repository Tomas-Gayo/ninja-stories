using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "UnsheatheAnimation", menuName = "Scriptable Objects/FSM/Player/Actions/UnsheatheAnimation")]
public class UnsheatheAnimation : FSMAction
{
    public CharacterAnimatorParamSO animParamSO;
    Animator animator;

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        animator = stateMachine.GetComponent<Animator>();

        animator.SetLayerWeight(animator.GetLayerIndex("Combat Layer"), 1);
        animator.SetTrigger(animParamSO.UnsheatheParamName);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }

    public override void OnUpdate(BaseStateMachine stateMachine) { }
}
