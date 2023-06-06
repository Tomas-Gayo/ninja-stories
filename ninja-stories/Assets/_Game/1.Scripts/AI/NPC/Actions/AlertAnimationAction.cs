using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "AlertAnimationAction", menuName = "Scriptable Objects/FSM/Actions/AlertAnimationAction")]
public class AlertAnimationAction : FSMAction
{
    [SerializeField] private CharacterAnimatorParamSO animParamSO;
    [SerializeField] private BaseState[] fromCombatStates;

    private bool fromCombat;

    public override void OnUpdate(BaseStateMachine stateMachine) { }

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        Animator animator = stateMachine.GetComponent<Animator>();

        foreach (var state in fromCombatStates)
        {
            if (state == stateMachine.PreviousState) fromCombat = true;
            else fromCombat = false;

        }

        // Play animations
        if (!fromCombat) animator.SetTrigger(animParamSO.UnsheatheParamName);

        animator.SetBool(animParamSO.IsMovingParamName, false);
        animator.SetLayerWeight(animator.GetLayerIndex("Combat Layer"), 1);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }
}
