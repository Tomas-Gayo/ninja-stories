using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class BoolEvent : UnityEvent<bool> { }

/// <summary>
/// The following methods must be called through an animator event.
/// This will enable or disable the attack collider of the weapon that is listening
/// </summary>
public class Attacker : MonoBehaviour
{
	[Header("Braodcasting on channels")]
	public BoolEvent leftHandToggleTriggerCollider;
	public BoolEvent rightHandToggleTriggerCollider;


	public void EnableLeftHandCollider()
	{
		leftHandToggleTriggerCollider?.Invoke(true);
	}

	public void DisableLeftHandCollider()
	{
		leftHandToggleTriggerCollider?.Invoke(false);
	}

	public void EnableRightHandCollider()
	{
		rightHandToggleTriggerCollider?.Invoke(true);
	}

	public void DisableRightHandCollider()
	{
		rightHandToggleTriggerCollider?.Invoke(false);
	}

}
