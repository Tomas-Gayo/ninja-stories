using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "QuestSORequestGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "QuestSO Request",
	    order = 120)]
	public sealed class QuestSORequestGameEvent : GameEventBase<QuestSORequest>
	{
	}
}