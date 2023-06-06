using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "ItemRequest")]
	public sealed class ItemRequestGameEventListener : BaseGameEventListener<ItemRequest, ItemRequestGameEvent, ItemRequestUnityEvent>
	{
	}
}