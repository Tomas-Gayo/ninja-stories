using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class InventoryItem
{
    [SerializeField] private ItemSO item;
    public int amount;

    public ItemSO Item => item; 

    public InventoryItem(ItemSO item, int amount)
    {
        this.item = item;           
        this.amount = amount;
    }
}

/// <summary>
/// Inventory System. it holds all the necessary to create an inventory and manage it.
/// </summary>
[CreateAssetMenu(fileName = "InventorySO", menuName = "Scriptable Objects/Inventory")]
public class InventorySO : ScriptableObject
{
    public int maxItems;
    public List<InventoryItem> items = new List<InventoryItem>();

    public void Initialize()
    {
        items.Clear();
    }

    public void AddItem(ItemSO item, int amount)
    {
        InventoryItem inventoryItem = items.Find((t) => { return t.Item == item; });

        if (inventoryItem != null)
        {
            inventoryItem.amount += amount;
            return;
        }

        if (items.Count >= maxItems)
        {
            // send error message in UI
            Debug.LogWarning("Cannot hold more items in inventory");
        }
        else
        {
            InventoryItem newInventoryItem = new InventoryItem(item, amount);
            items.Add(newInventoryItem);
        }
    }

    public bool ContainsItem(ItemSO item)
    {
        InventoryItem inventoryItem = items.Find((t) => { return t.Item == item; });
        return items.Contains(inventoryItem);
    }

    private void OnEnable()
    {
        Initialize();
    }
}
