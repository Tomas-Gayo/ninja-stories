using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "AudioRequest")]
	public sealed class AudioRequestGameEventListener : BaseGameEventListener<AudioRequest, AudioRequestGameEvent, AudioRequestUnityEvent>
	{
	}
}