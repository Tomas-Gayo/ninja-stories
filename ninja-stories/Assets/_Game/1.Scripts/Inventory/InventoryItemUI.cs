using UnityEngine;
using UnityEngine.UI;
using ScriptableObjectArchitecture;
using TMPro;


/// <summary>
/// 
/// </summary>
public class InventoryItemUI : MonoBehaviour
{
	[Header("UI Elements")]
	[SerializeField] private Image itemIcon;
	[SerializeField] private TextMeshProUGUI itemCount;

	[Header("Configuration")]
	[SerializeField] private InventoryItemSlotConfig slotConfig;

	[Header("Broadcasting on")]
	[SerializeField] private TooltipRequestGameEvent tooltipRequest;

	[HideInInspector] public InventoryItem currentItem;

	private void OnEnable()
	{
		ResetItem();
	}

	public void SetItemUI(InventoryItem inventoryItem)
	{
		currentItem = inventoryItem;

		slotConfig.SetDefaultInventorySlotConfig(itemIcon, itemCount);

		itemIcon.sprite = currentItem.Item.icon;
		itemCount.text = currentItem.amount.ToString();
	}

	public void ResetItem()
	{
		currentItem = null;
		
		slotConfig.SetDisabledInventorySlotConfig(itemIcon, itemCount);
	}

	public void DisplayItemTooltip()
    {
		if (currentItem != null)
        {
			var request = new TooltipRequest(
			title: currentItem.Item.name,
			description: currentItem.Item.description
		);

			tooltipRequest.Raise(request);
		}
	}
}
