using UnityEngine;
using UnityEngine.Localization.Components;
using TMPro;

	
/// <summary>
/// 
/// </summary>
public class QuestInfoUI : MonoBehaviour
{
	[SerializeField] private Translator translator;
	[Space]
	[Header("UI elements")]
	[SerializeField] private LocalizeStringEvent titleTxtComponent;
	[SerializeField] private LocalizeStringEvent descriptionTxtComponent;
	[SerializeField] private TextMeshProUGUI statusTxt;
	[SerializeField] private GameObject acceptBtn;
	[SerializeField] private GameObject completeBtn;

	[Header("Broadcasting on")]
	[SerializeField] private BaseQuestChannel baseQuestChannel;

	private BaseQuest currentQuest;
	private QuestUI currentQuestUI;

    public void FillQuestInfoPanel(BaseQuest quest, QuestUI questUI)
    {
		currentQuest = quest;
		currentQuestUI = questUI;

		titleTxtComponent.StringReference = translator.GetTranslation(quest.Title);
		descriptionTxtComponent.StringReference = translator.GetTranslation(quest.Description);
		statusTxt.text = quest.GetStatus();

		UpdateQuestInfoPanelButtons();
	}

	public void UpdateQuestInfoPanelButtons()
    {
		if (currentQuest != null) 
		{
			switch (currentQuest.State)
			{
				case QuestState.pending:
					acceptBtn.SetActive(true);
					completeBtn.SetActive(false);
					break;
				case QuestState.active:
					acceptBtn.SetActive(false);
					completeBtn.SetActive(true);
					break;
				case QuestState.complete:
					acceptBtn.SetActive(false);
					completeBtn.SetActive(false);
					break;
			}
		}
	}

	public void ActivateQuest()
    {
		baseQuestChannel.OnQuestActivate(currentQuest);
		currentQuestUI.OnQuestStateUpdated();
    }

	public void CompleteQuest()
    {
		baseQuestChannel.OnQuestCompleted(currentQuest);
		currentQuestUI.OnQuestStateUpdated();
	}
}
