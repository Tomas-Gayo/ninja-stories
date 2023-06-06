using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "PatrolAnimation", menuName = "Scriptable Objects/FSM/Actions/PatrolAnimation")]
public class PatrolAnimationAction : FSMAction
{
    [SerializeField] private CharacterAnimatorParamSO animParamSO;

    public override void OnUpdate(BaseStateMachine stateMachine) { }

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        Animator animator = stateMachine.GetComponent<Animator>();

        // Play animations
        animator.SetBool(animParamSO.RunParamName, false);
        animator.SetBool(animParamSO.IsMovingParamName, true);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }
}
