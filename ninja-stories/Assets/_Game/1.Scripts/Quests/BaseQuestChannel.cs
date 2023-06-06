using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "BaseQuestChannel", menuName = "Scriptable Objects/Quests/BaseQuestChannel")]
public class BaseQuestChannel : ScriptableObject
{
    public event UnityAction<BaseQuest> ActivateQuest = delegate { };
    public event UnityAction<BaseQuest> CompleteQuest = delegate { };

    public void OnQuestActivate(BaseQuest quest)
    {
        ActivateQuest.Invoke(quest);
    }

    public void OnQuestCompleted(BaseQuest quest)
    {
        CompleteQuest.Invoke(quest);
    }
}