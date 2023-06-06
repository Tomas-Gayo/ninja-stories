using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class Ragdoll : MonoBehaviour
{
	Rigidbody[] rigidBodies;
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        rigidBodies = GetComponentsInChildren<Rigidbody>();
        DeactivateRagdoll();
    }

    public void DeactivateRagdoll()
    {
        foreach(var rigidBody in rigidBodies)
        {
            rigidBody.isKinematic = true;
            Collider col = rigidBody.GetComponent<Collider>();
            col.isTrigger = true;
        }
        animator.enabled = true;
    }

    public void ActivateRagdoll()
    {
        foreach(var rigidBody in rigidBodies)
        {
            Collider col = rigidBody.GetComponent<Collider>();
            col.isTrigger = false;
            rigidBody.isKinematic = false;
        }
        animator.enabled = false;
    }
}
