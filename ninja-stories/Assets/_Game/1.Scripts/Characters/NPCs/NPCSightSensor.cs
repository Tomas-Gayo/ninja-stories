using UnityEngine;

	
/// <summary>
/// The NPC will check if the player is in the alert or attack zone, 
/// moreover, there is a raycast checking if the player is on sight 
/// the NPC will detect the target by a distance and an agle on the forward direction
/// </summary>
public class NPCSightSensor : MonoBehaviour
{
	public bool IsTargetInAlertZone { get; private set; }
	public bool IsTargetInAttackZone { get; private set; }
	public bool IsTargetInDetectionZone { get; private set; }
	public GameObject CurrentTarget { get; private set; }

    
	public void OnZoneAlertTriggerChange(bool hasEntered, GameObject target)
    {
        IsTargetInAlertZone = hasEntered;

        if (hasEntered)
            CurrentTarget = target;
        else
            CurrentTarget = null;
    }

    public void OnZoneAttackTriggerChange(bool hasEntered, GameObject target)
    {
        IsTargetInAttackZone = hasEntered;
    }

    public void OnZoneDetectionTriggerChange(bool hasEntered, GameObject target)
    {
        IsTargetInDetectionZone = hasEntered;
    }


    // The NPC will check in a range if the target is on sight
    //public bool IsTargetOnSight()
    //{
    //    if (CurrentTarget == null)
    //        return false;

    //    if (Vector3.Distance(transform.position, CurrentTarget.transform.position) < detectionDistance)
    //    {
    //        Vector3 dirToPlayer = (CurrentTarget.transform.position - transform.position).normalized;
    //        float angle = Vector3.Angle(transform.forward, dirToPlayer);

    //        if (angle < viewAngle / 2)
    //        {
    //            if (!Physics.Linecast(transform.position, CurrentTarget.transform.position))
    //            {
    //                return true;
    //            }
    //        }
    //    }
    //    return false;
    //}
}
