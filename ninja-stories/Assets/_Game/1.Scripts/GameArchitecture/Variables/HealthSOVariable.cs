using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class HealthSOEvent : UnityEvent<HealthSO> { }

	[CreateAssetMenu(
	    fileName = "HealthSOVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "UpdateHealthChannel",
	    order = 120)]
	public class HealthSOVariable : BaseVariable<HealthSO, HealthSOEvent>
	{
	}
}