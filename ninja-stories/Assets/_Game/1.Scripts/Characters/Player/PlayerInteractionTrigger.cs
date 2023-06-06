using UnityEngine;
using ScriptableObjectArchitecture;

	
/// <summary>
/// Add this script to the player. It has two tasks when collides with collider 
/// that has the correct tag: 1. saves the component interactable of the target, 
/// 2. sends an event to activate the spacial UI
/// </summary>
public class PlayerInteractionTrigger : MonoBehaviour
{
    [Header("Configuration")]
    public string interactableTag;
    [SerializeField] private InputReader inputReader;

    [Header("Broadcasting Channels")]
    public BoolGameEvent interactionToggledEvent;

    private Interactable interactable;

    private void OnEnable()
    {
        inputReader.InteractEvent += DoInteraction;
    }
    private void OnDisable()
    {
        inputReader.InteractEvent -= DoInteraction;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(interactableTag))
        {
            interactable = other.GetComponent<Interactable>();
        }

        SendInteractionToggleEvent();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(interactableTag))
        {
            interactable = null;
        }

        SendInteractionToggleEvent();
    }

    public void DoInteraction()
    {
        if (interactable != null)
        {
            interactable.Interact();
        }
    }

    public void SendInteractionToggleEvent()
    {
        interactionToggledEvent?.Raise(interactable != null);
    }

    public void EndInteraction()
    {
        interactable = null;

        SendInteractionToggleEvent();
    }
}
