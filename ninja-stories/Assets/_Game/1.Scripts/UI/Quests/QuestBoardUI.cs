using System.Collections.Generic;
using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class QuestBoardUI : MonoBehaviour
{
    [SerializeField] private QuestUI[] questUI;

    public void DisplayQuests(List<BaseQuest> quests)
    {
        for (int i = 0; i < quests.Count; i++)
        {
            if (quests[i] != null)
            {
                questUI[i].gameObject.SetActive(true);
                questUI[i].DisplayQuest(quests[i]);
            }
        }

    }
}
