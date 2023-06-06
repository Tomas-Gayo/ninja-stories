using UnityEngine;

[CreateAssetMenu(fileName = "EnemyQuest", menuName = "Scriptable Objects/Quests/Enemy Quest")]
public class EnemyQuest : BaseQuest
{
    [Header("Config")]
    [SerializeField] private EnemySO enemyToKill;
    [SerializeField] private int amountToCollect;

    [Header("Broadcasting on")]
    [SerializeField] private BaseQuestChannel baseQuestChannel;
    [SerializeField] private EnemyKilledChannel enemyKilledChannel;


    private int currentAmount;

    private void OnEnable()
    {
        State = QuestState.pending;
        currentAmount = 0;
        enemyKilledChannel.UpdateEnemyQuest += EnemyKilled;
        baseQuestChannel.ActivateQuest += ActivateQuest;
        baseQuestChannel.CompleteQuest += TryToCompleteQuest;
    }

    private void OnDisable()
    {
        enemyKilledChannel.UpdateEnemyQuest -= EnemyKilled;
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
        return $"{enemyToKill.name}: {currentAmount} / {amountToCollect}";
    }

    public void EnemyKilled(EnemySO enemy)
    {
        if (State != QuestState.active)
            return;

        if (enemy == enemyToKill)
        {
            currentAmount ++;
        }
    }
}
