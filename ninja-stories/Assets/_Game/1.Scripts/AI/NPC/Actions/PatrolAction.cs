using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "PatrolAction", menuName = "Scriptable Objects/FSM/Actions/Patrol")]
public class PatrolAction : FSMAction
{
    private NavMeshAgent agent;
    private NPCStateCongifuration config;
    private NPCPathway path;

    public override void OnUpdate(BaseStateMachine stateMachine) { }

    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        agent = stateMachine.GetComponent<NavMeshAgent>();
        config = stateMachine.GetComponent<NPCStateCongifuration>();
        path = stateMachine.GetComponent<NPCPathway>();

        config.WalkingConfig(agent);

        agent.SetDestination(path.GetNextPosition().position);

    }

    public override void OnExitState(BaseStateMachine stateMachine) { }
}
