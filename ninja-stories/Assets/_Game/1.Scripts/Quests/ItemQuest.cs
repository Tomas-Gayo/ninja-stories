using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "ItemQuest", menuName = "Scriptable Objects/Quests/Item Quest")]
public class ItemQuest : BaseQuest
{
    [Header("Config")]
    [SerializeField] private ItemSO itemToCollect;
    [SerializeField] private int amountToCollect;

    [Header("Broadcasting on")]
    [SerializeField] private BaseQuestChannel baseQuestChannel;
    [SerializeField] private ItemCollectedChannel itemCollectedChannel;


    private int currentAmount;

    private void OnEnable()
    {
        State = QuestState.pending;
        currentAmount = 0;
        itemCollectedChannel.UpdateItemQuest += ItemCollected;
        baseQuestChannel.ActivateQuest += ActivateQuest;
        baseQuestChannel.CompleteQuest += TryToCompleteQuest;
    }

    private void OnDisable()
    {
        itemCollectedChannel.UpdateItemQuest -= ItemCollected;
        baseQuestChannel.ActivateQuest -= ActivateQuest;
        baseQuestChannel.CompleteQuest -= TryToCompleteQuest;
    }

    public override void ActivateQuest(BaseQuest quest)
    {
        if (Id != quest.Id) return;

        if (State == QuestState.pending)
        {
            State = QuestState.active;
        }
    }

    public override void TryToCompleteQuest(BaseQuest quest)
    {
        if (Id != quest.Id) return;

        if (currentAmount >= amountToCollect && State == QuestState.active)
        {
            State = QuestState.complete;
        }
    }
    public override string GetStatus()
    {
        return $"{itemToCollect.name}: {currentAmount} / {amountToCollect}";
    }

    public void ItemCollected(ItemConfig item)
    {
        if (State != QuestState.active)
            return;

        if ( item.CurrentItem == itemToCollect)
        {
            currentAmount += item.ItemAmount;
        }
    }
}
