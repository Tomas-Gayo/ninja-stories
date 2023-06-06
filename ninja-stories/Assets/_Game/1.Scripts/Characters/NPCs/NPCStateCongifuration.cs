using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Controls the movement of the NPC by providing move data and patrol pathway
/// </summary>
public class NPCStateCongifuration : MonoBehaviour
{
    
    [SerializeField] private NPCMovementConfigSO configSO;

    public void StopAgentConfig(NavMeshAgent agent)
    {
        agent.isStopped = true;
    }

    public void WalkingConfig(NavMeshAgent agent)
    {
        agent.isStopped = false;
        agent.speed = configSO.WalkSpeed;
        agent.angularSpeed = configSO.RotationSpeed;
        agent.stoppingDistance = 1.5f;
    }

    public void RunConfig(NavMeshAgent agent)
    {
        agent.isStopped = false;
        agent.speed = configSO.RunSpeed;
        agent.angularSpeed = configSO.RotationSpeed;
        agent.stoppingDistance = 1.5f;
    }

}

