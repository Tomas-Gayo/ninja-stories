/// <summary>
/// 
/// </summary>
[System.Serializable]
public class ItemRequest
{
    public ItemSO item;
    public int amount;
    public ItemRequest(ItemSO item, int amount)
    {
        this.item = item;
        this.amount = amount;
    }
}