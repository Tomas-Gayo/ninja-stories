using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "GettingHitAnimation", menuName = "Scriptable Objects/FSM/Player/Actions/GettingHitAnimation")]
public class GettingHitAnimation : FSMAction
{
    [SerializeField] private CharacterAnimatorParamSO animParamSO;

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        Animator animator = stateMachine.GetComponent<Animator>();

        animator.SetTrigger(animParamSO.GetHitParamName);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }

    public override void OnUpdate(BaseStateMachine stateMachine) { }
}
