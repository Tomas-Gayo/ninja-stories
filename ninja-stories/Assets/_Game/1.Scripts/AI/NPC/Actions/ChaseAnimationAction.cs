using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "ChaseAnimation", menuName = "Scriptable Objects/FSM/Actions/ChaseAnimation")]
public class ChaseAnimationAction : FSMAction
{
    [SerializeField] private CharacterAnimatorParamSO animParamSO;
    public override void OnUpdate(BaseStateMachine stateMachine) { }

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        Animator animator = stateMachine.GetComponent<Animator>();

        // Play animations
        animator.SetBool(animParamSO.RunParamName, true);
        animator.SetBool(animParamSO.IsMovingParamName, true);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }
}
