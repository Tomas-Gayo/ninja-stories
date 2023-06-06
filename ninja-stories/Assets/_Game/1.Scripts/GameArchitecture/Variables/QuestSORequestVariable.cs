using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class QuestSORequestEvent : UnityEvent<QuestSORequest> { }

	[CreateAssetMenu(
	    fileName = "QuestSORequestVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "QuestSO Request",
	    order = 120)]
	public class QuestSORequestVariable : BaseVariable<QuestSORequest, QuestSORequestEvent>
	{
	}
}