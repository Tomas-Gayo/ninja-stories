using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class InventoryManager : MonoBehaviour
{
	[SerializeField] private InventoryUI inventoryUI;

	public void DisplayInventoryUI(InventorySO inventory)
    {
		if (inventory != null)
        {
            inventoryUI.FillInventoryUI(inventory);
        }
    }

}
