using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class ZoneTriggerEvent : UnityEvent<bool, GameObject> { }

/// <summary>
/// 
/// </summary>
[RequireComponent(typeof(SphereCollider))]
public class ZoneTriggerChecker : MonoBehaviour
{
	[SerializeField] private ZoneTriggerEvent onZoneTriggerChange;
	[SerializeField] private string targetTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(targetTag))
            onZoneTriggerChange.Invoke(true, other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(targetTag))
            onZoneTriggerChange.Invoke(false, other.gameObject);
    }
}
