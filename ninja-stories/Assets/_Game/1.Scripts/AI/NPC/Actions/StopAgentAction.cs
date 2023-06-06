using UnityEngine;
using UnityEngine.AI;
/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "StopAgentAction", menuName = "Scriptable Objects/FSM/Actions/Stop Agent")]
public class StopAgentAction : FSMAction
{

    [SerializeField] private CharacterAnimatorParamSO animParamSO;

    private NavMeshAgent agent;
    private NPCStateCongifuration config;


    public override void OnUpdate(BaseStateMachine stateMachine)
    {
        agent = stateMachine.GetComponent<NavMeshAgent>();
        config = stateMachine.GetComponent<NPCStateCongifuration>();
        
        config.StopAgentConfig(agent);
    }

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        Animator animator = stateMachine.GetComponent<Animator>();

        // Play animations
        animator.SetBool(animParamSO.RunParamName, false);
        animator.SetBool(animParamSO.IsMovingParamName, false);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }
}
