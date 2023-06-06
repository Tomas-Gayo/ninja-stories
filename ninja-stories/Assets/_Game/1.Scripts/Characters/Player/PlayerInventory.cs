using UnityEngine;
using UnityEngine.Events;
using ScriptableObjectArchitecture;

/// <summary>
/// Current Inventory of the player
/// </summary>
public class PlayerInventory : MonoBehaviour
{
    [Header("Configuration")]
    [SerializeField] private InputReader inputReader;
	[SerializeField] private InventorySO currentInventory;

    [Header("Broadcasting On")]
	[SerializeField] private InventorySOGameEvent updateInventoryUI;
    [SerializeField] private UnityEvent itemCollectedEvent;
	[SerializeField] private UnityEvent onInventoryOpenedEvent;
	[SerializeField] private UnityEvent onInventoryClosedEvent;

	[SerializeField] private ItemCollectedChannel itemCollectedChannel;

	private void OnEnable()
	{
		// Enable listners
		inputReader.OpenInventoryEvent += OpenInventory;
		inputReader.CloseInventoryEvent += CloseInventory;
	}

	private void OnDisable()
	{
		// Disable listeners
		inputReader.OpenInventoryEvent -= OpenInventory;
		inputReader.CloseInventoryEvent -= CloseInventory;
	}

	public void AddItemInInventory(ItemConfig item)
    {
        currentInventory.AddItem(item.CurrentItem, item.ItemAmount);
        Destroy(item.gameObject);
        itemCollectedEvent?.Invoke();
		itemCollectedChannel?.OnItemCollected(item);
    }

	private void OpenInventory()
    {
		onInventoryOpenedEvent?.Invoke();
		updateInventoryUI?.Raise(currentInventory);
    }

	private void CloseInventory()
    {
		onInventoryClosedEvent?.Invoke();
	}
}
