using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "IdleAction", menuName = "Scriptable Objects/FSM/Actions/IdleAction")]
public class IdleAction : ScriptableObject
{
    //private NavMeshAgent agent;
    //private NPCStateCongifuration config;
    //private NPCPathway path;

    //public override void OnUpdate(BaseStateMachine stateMachine)
    //{
    //    if (path.HasReached(agent))
    //        agent.SetDestination(path.GetNextPosition().position);
    //}

    //public override void OnEnterState(BaseStateMachine stateMachine)
    //{
    //    agent = stateMachine.GetComponent<NavMeshAgent>();
    //    config = stateMachine.GetComponent<NPCStateCongifuration>();
    //    path = stateMachine.GetComponent<NPCPathway>();

    //    config.WalkingConfig(agent);
    //}

    //public override void OnExitState(BaseStateMachine stateMachine) { }
}
