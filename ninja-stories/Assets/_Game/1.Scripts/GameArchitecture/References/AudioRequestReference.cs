using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class AudioRequestReference : BaseReference<AudioRequest, AudioRequestVariable>
	{
	    public AudioRequestReference() : base() { }
	    public AudioRequestReference(AudioRequest value) : base(value) { }
	}
}