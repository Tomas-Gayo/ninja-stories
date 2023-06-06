using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "TooltipRequestGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Tooltip Request",
	    order = 120)]
	public sealed class TooltipRequestGameEvent : GameEventBase<TooltipRequest>
	{
	}
}