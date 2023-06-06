using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "HealthSOGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "UpdateHealthChannel",
	    order = 120)]
	public sealed class HealthSOGameEvent : GameEventBase<HealthSO>
	{
	}
}