using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "InventorySOGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Inventory Request",
	    order = 120)]
	public sealed class InventorySOGameEvent : GameEventBase<InventorySO>
	{
	}
}