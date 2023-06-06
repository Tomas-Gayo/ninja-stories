using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "SheatheAnimation", menuName = "Scriptable Objects/FSM/Player/Actions/SheatheAnimation")]
public class SheatheAnimation : FSMAction
{
    public CharacterAnimatorParamSO animSO;
    Animator animator;

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        animator = stateMachine.GetComponent<Animator>();

        animator.SetLayerWeight(animator.GetLayerIndex("Combat Layer"), 0);
        animator.SetTrigger(animSO.SheatheParamName);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }

    public override void OnUpdate(BaseStateMachine stateMachine) { }
}
