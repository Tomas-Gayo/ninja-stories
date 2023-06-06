using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "ItemRequestGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Item Requet",
	    order = 120)]
	public sealed class ItemRequestGameEvent : GameEventBase<ItemRequest>
	{
	}
}