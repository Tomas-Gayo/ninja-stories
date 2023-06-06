using System.Collections.Generic;
using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class InventoryUI : MonoBehaviour
{
	[SerializeField] private List<InventoryItemUI> inventoryItems;

    public void FillInventoryUI(InventorySO inventory)
    {
		if (inventoryItems == null) inventoryItems = new List<InventoryItemUI>();

		for (int i = 0; i < inventory.items.Count; i++)
        {
			inventoryItems[i].SetItemUI(inventory.items[i]);
        }
	}

    // This methods will be for futere interaction 
    public void UpdateItemInInventory(InventoryItem itemToUpdate)
    {
        //if (inventoryItems == null) inventoryItems = new List<InventoryItemUI>();

        int index = inventoryItems.FindIndex(t => t.currentItem == itemToUpdate);

        inventoryItems[index].SetItemUI(itemToUpdate);
    }

    public void RemoveItemInInventory(InventoryItem itemToRemove)
    {
        int index = inventoryItems.FindIndex(t => t.currentItem == itemToRemove);

        inventoryItems[index].ResetItem();
    }
}
