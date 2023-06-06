using System.Collections.Generic;
using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class QuestManager : MonoBehaviour
{
    [SerializeField] private List<BaseQuest> quests;
    [SerializeField] private QuestBoardUI questBoardUI;

    private void Start()
    {
        questBoardUI.DisplayQuests(quests);
    }
}
