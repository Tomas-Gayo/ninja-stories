using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "TooltipRequest")]
	public sealed class TooltipRequestGameEventListener : BaseGameEventListener<TooltipRequest, TooltipRequestGameEvent, TooltipRequestUnityEvent>
	{
	}
}