using UnityEngine;

//[CreateAssetMenu(fileName = "NewQuest", menuName = "Scriptable Objects/QuestSystem/Quest")]
public abstract class BaseQuest : ScriptableObject
{
    [Header("UI string references")]
    [SerializeField] private string title;
    [SerializeField] private string description;

    [Header("Config")]
    [SerializeField] private int id;
    [SerializeField] private QuestState state;
    [SerializeField] private QuestSOConfig questConfig;


    public string Title => title;
    public string Description => description;
    public int Id => id;

    public QuestState State
    {
        get { return state; }
        set { state = value; }
    }

    public Sprite GetStateIcon()
    {
        return questConfig.GetQuestStateIcon(this);
    }

    public abstract void ActivateQuest(BaseQuest quest);
    public abstract void TryToCompleteQuest(BaseQuest quest);
    public abstract string GetStatus();

}
