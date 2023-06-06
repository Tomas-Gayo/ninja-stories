using UnityEngine;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "NewQuestSOConfig", menuName = "Scriptable Objects/QuestSystem/QuestSOConfig")]
public class QuestSOConfig : ScriptableObject
{
	[SerializeField] private Sprite pendingStateIcon;
	[SerializeField] private Sprite activeStateIcon;
	[SerializeField] private Sprite completeStateIcon;

	public Sprite GetQuestStateIcon(BaseQuest quest)
    {
        return quest.State switch
        {
            QuestState.pending => pendingStateIcon,
            QuestState.active => activeStateIcon,
            QuestState.complete => completeStateIcon,
            _ => null,
        };
	}
}
