using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Controls the movement of the NPC by providing move data and patrol pathway
/// </summary>
public class NPCPathway : MonoBehaviour
{

    [SerializeField] private Transform[] pathway;

    public Transform CurrentPoint => pathway[currentPoint];

    // References
    private int currentPoint = 0;


    // Next point to patrol
    public Transform GetNextPosition()
    {
        Transform point = pathway[currentPoint];
        currentPoint = (currentPoint + 1) % pathway.Length;
        return point;
    }

    // Checks if destination reached
    public bool HasReached(NavMeshAgent agent)
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    return true;
                }
            }
        }

        return false;
    }
}

