using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class ItemRequestEvent : UnityEvent<ItemRequest> { }

	[CreateAssetMenu(
	    fileName = "ItemRequestVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Item Requet",
	    order = 120)]
	public class ItemRequestVariable : BaseVariable<ItemRequest, ItemRequestEvent>
	{
	}
}