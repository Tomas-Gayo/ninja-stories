using UnityEngine;
using UnityEditor;

public class EnemySightSensor : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField, Tooltip("Tag of the target we want to find.")] 
    private string targetTag = "Player";

    public float detectionDistance = 10f;
    public float viewAngle = 90f;


    // References
    public Transform Player { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(targetTag))
        {
            Player = other.gameObject.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(targetTag))
        {
            Player = null;
        }
    }

    public bool FindTarget()
    {
        if (Player == null)
            return false;

        if (Vector3.Distance(transform.position, Player.transform.position) < detectionDistance)
        {
            Vector3 dirToPlayer = (Player.transform.position - transform.position).normalized;
            float angle = Vector3.Angle(transform.forward, dirToPlayer);

            if (angle < viewAngle / 2)
            {
                if (!Physics.Linecast(transform.position, Player.transform.position))
                {
                    return true;
                }
            }
        }
        return false;
    }
}