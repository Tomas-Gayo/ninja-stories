using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class ItemAudio : DefaultAudioChannel
{
	[SerializeField] private AudioConfigurationSO audioConfiguration;

	[Header("Audio Clips")]
	[SerializeField] private AudioSO collect;

	public void PlayCollectItem() => PlayAudioClipRequest(collect, audioConfiguration, transform.position);
}
