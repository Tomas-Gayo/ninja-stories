using UnityEngine;
using ScriptableObjectArchitecture;

	
/// <summary>
/// 
/// </summary>
public class DefaultAudioChannel : MonoBehaviour
{
	[SerializeField] protected AudioRequestGameEvent audioRequestChannel;

	public void PlayAudioClipRequest(AudioSO audioToPlay, AudioConfigurationSO audioToPlayConfig, Vector3 position)
	{
		var request = new AudioRequest(
			audioClips: audioToPlay,
			audioConfig: audioToPlayConfig,
			worldPosition: position
		);

		audioRequestChannel.Raise(request);
    }
}
