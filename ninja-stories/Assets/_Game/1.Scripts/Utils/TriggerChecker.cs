using UnityEngine;
using UnityEngine.Events;

public class TriggerChecker : MonoBehaviour
{
    [Header("Extra config")]
    public string validTag;

    [Header("Events")]
    public UnityEvent onTriggerEnter;
    public UnityEvent onTriggerStay;
    public UnityEvent onTriggerExit;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(validTag))
        {
            if (onTriggerEnter != null)
                onTriggerEnter.Invoke();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(validTag))
        {
            if (onTriggerStay != null)
                onTriggerStay.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(validTag))
        {
            if (onTriggerExit != null)
                onTriggerExit.Invoke();
        }
    }
}
