using UnityEngine;

/// <summary>
/// Add the info of current item and
/// sends the information to the inventory if required
/// </summary>
public class ItemConfig : MonoBehaviour
{
    [SerializeField] private ItemSO currentItem;
    [SerializeField] private Vector2Int itemAmountRange;

    private PlayerInventory currentPlayerInventory;
    private int itemAmount;

    public ItemSO CurrentItem => currentItem;
    public int ItemAmount => itemAmount;

    private void Start()
    {
        itemAmount = Random.Range(itemAmountRange.x, itemAmountRange.y);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentPlayerInventory = other.GetComponentInChildren<PlayerInventory>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentPlayerInventory = null;
        }
    }

    public void SendItemToInventory()
    {
        if (currentPlayerInventory != null)
        {
            Debug.Log("Interaction");
            currentPlayerInventory.AddItemInInventory(this);
        }
    }
}
