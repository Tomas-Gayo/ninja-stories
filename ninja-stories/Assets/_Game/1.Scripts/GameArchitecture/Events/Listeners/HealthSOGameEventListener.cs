using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "HealthSO")]
	public sealed class HealthSOGameEventListener : BaseGameEventListener<HealthSO, HealthSOGameEvent, HealthSOUnityEvent>
	{
	}
}