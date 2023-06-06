using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class HealthSOReference : BaseReference<HealthSO, HealthSOVariable>
	{
	    public HealthSOReference() : base() { }
	    public HealthSOReference(HealthSO value) : base(value) { }
	}
}