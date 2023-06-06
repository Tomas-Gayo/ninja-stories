using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class TooltipRequestReference : BaseReference<TooltipRequest, TooltipRequestVariable>
	{
	    public TooltipRequestReference() : base() { }
	    public TooltipRequestReference(TooltipRequest value) : base(value) { }
	}
}