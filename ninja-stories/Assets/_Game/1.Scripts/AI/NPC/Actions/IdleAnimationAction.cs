using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IdleAnimationAction", menuName = "Scriptable Objects/FSM/Actions/IdleAnimationAction")]
public class IdleAnimationAction : FSMAction
{
    [SerializeField] private CharacterAnimatorParamSO animParamSO;
    [SerializeField] private BaseState[] fromCombatStates;

    bool fromCombat;

    public override void OnUpdate(BaseStateMachine stateMachine) { }

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        Animator animator = stateMachine.GetComponent<Animator>();

        foreach (var state in fromCombatStates)
        {
            if (state == stateMachine.PreviousState) fromCombat = true;
            else fromCombat = false;

        }

        if (fromCombat) 
        {
            animator.SetLayerWeight(animator.GetLayerIndex("Combat Layer"), 0);
            animator.SetTrigger(animParamSO.SheatheParamName);
        }
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }
}
