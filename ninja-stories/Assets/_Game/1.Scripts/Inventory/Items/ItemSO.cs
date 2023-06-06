using UnityEngine;

/// <summary>
/// It holds all the data related to an item
/// </summary>
[CreateAssetMenu(fileName = "NewItem", menuName = "Scriptable Objects/Item")]
public class ItemSO : ScriptableObject
{
    public Sprite icon;
    public string itemName;
    public string description;
}
