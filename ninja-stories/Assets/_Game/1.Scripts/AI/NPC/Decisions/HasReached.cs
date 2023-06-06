using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "NewHasReached", menuName = "Scriptable Objects/FSM/Decisions/HasReached")]
public class HasReached : Decision
{
    private NavMeshAgent agent;
    private NPCPathway path;
    public override bool Decide(BaseStateMachine stateMachine)
    {
        agent = stateMachine.GetComponent<NavMeshAgent>();
        path = stateMachine.GetComponent<NPCPathway>();

        return path.HasReached(agent);
    }
}
