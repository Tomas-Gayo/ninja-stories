using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "ItemCollectedChannel", menuName = "Scriptable Objects/Quests/Item Collected Channel")]
public class ItemCollectedChannel : ScriptableObject
{
    public event UnityAction<ItemConfig> UpdateItemQuest = delegate { };

    public void OnItemCollected(ItemConfig itemConfig)
    {
        UpdateItemQuest.Invoke(itemConfig);
    }
}
