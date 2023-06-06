using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class ItemRequestReference : BaseReference<ItemRequest, ItemRequestVariable>
	{
	    public ItemRequestReference() : base() { }
	    public ItemRequestReference(ItemRequest value) : base(value) { }
	}
}