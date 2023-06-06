using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "QuestSORequest")]
	public sealed class QuestSORequestGameEventListener : BaseGameEventListener<QuestSORequest, QuestSORequestGameEvent, QuestSORequestUnityEvent>
	{
	}
}