using UnityEngine;
using UnityEngine.AI;

	
/// <summary>
/// 
/// </summary>
public class DebugNavMeshAgent : MonoBehaviour
{
	public bool velocity;
    public Color velocityColor = Color.yellow;
	public bool desiredVelocity;
    public Color desiredVelocityColor = Color.red;
	public bool path;
    public Color pathColor = Color.blue;

	NavMeshAgent agent;

    private void Start()
    {
		agent = GetComponent<NavMeshAgent>();
    }

    private void OnDrawGizmos()
    {
        if (velocity)
        {
            Gizmos.color = velocityColor;
            Gizmos.DrawLine(transform.position, transform.position + agent.velocity);
        }

        if (desiredVelocity)
        {
            Gizmos.color = desiredVelocityColor;
            Gizmos.DrawLine(transform.position,transform.position + agent.desiredVelocity);
        }

        if (path)
        {
            Gizmos.color = pathColor;
            var agentPath = agent.path;
            Vector3 prevCorner = transform.position;
            foreach(var corner in agentPath.corners)
            {
                Gizmos.DrawLine(prevCorner, corner);
                Gizmos.DrawSphere(corner, 0.1f);
                prevCorner = corner;
            }
        }
    }
}
