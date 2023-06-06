using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class TooltipRequestEvent : UnityEvent<TooltipRequest> { }

	[CreateAssetMenu(
	    fileName = "TooltipRequestVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Tooltip Request",
	    order = 120)]
	public class TooltipRequestVariable : BaseVariable<TooltipRequest, TooltipRequestEvent>
	{
	}
}