using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "AudioRequestGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Audio Request",
	    order = 120)]
	public sealed class AudioRequestGameEvent : GameEventBase<AudioRequest>
	{
	}
}