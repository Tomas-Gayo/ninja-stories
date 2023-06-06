using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "ChaseAction", menuName = "Scriptable Objects/FSM/Actions/Chase")]
public class ChaseAction : FSMAction
{
    private NavMeshAgent agent;
    private NPCStateCongifuration config;
    private NPCSightSensor sensor;

    public override void OnUpdate(BaseStateMachine stateMachine)
    {
        GameObject target = sensor.CurrentTarget;

        if (target != null)
            agent.SetDestination(target.transform.position);       
    }
    public override void OnEnterState(BaseStateMachine stateMachine)
    {
        config = stateMachine.GetComponent<NPCStateCongifuration>();
        sensor = stateMachine.GetComponent<NPCSightSensor>();
        agent = stateMachine.GetComponent<NavMeshAgent>();

        config.RunConfig(agent);
    }

    public override void OnExitState(BaseStateMachine stateMachine) { }
}
