using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization.Components;

/// <summary>
/// 
/// </summary>
public class QuestUI : MonoBehaviour
{
	[SerializeField] private Translator translator;
	[Space]
	[Header("UI Elements")]
	[SerializeField] private LocalizeStringEvent titleTextComponent;
	[SerializeField] private Image stateIcon;
	[SerializeField] private QuestInfoUI questInfoUI;

	private BaseQuest currentQuest;
    
    public void DisplayQuest(BaseQuest quest)
	{
		currentQuest = quest;
	
		titleTextComponent.StringReference = translator.GetTranslation(quest.Title);
		stateIcon.sprite = currentQuest.GetStateIcon();
	}

	public void OnQuestSelected()
	{
		questInfoUI.gameObject.SetActive(true);
		questInfoUI.FillQuestInfoPanel(currentQuest, this);
	}

	public void OnQuestStateUpdated()
	{
		stateIcon.sprite = currentQuest.GetStateIcon();
	}

}
