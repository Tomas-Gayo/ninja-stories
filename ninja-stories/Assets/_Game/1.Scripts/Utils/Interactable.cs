using UnityEngine;
using UnityEngine.Events;

	
/// <summary>
/// 
/// </summary>
public class Interactable : MonoBehaviour
{
	[SerializeField] private UnityEvent interactEvent;

	public void Interact()
    {
		interactEvent?.Invoke();
    }
}
