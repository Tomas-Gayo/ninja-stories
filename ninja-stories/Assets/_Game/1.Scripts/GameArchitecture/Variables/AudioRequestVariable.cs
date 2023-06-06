using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class AudioRequestEvent : UnityEvent<AudioRequest> { }

	[CreateAssetMenu(
	    fileName = "AudioRequestVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Audio Request",
	    order = 120)]
	public class AudioRequestVariable : BaseVariable<AudioRequest, AudioRequestEvent>
	{
	}
}