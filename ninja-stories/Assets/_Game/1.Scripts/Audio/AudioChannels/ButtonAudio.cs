using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class ButtonAudio : DefaultAudioChannel
{
	[SerializeField] private AudioConfigurationSO audioConfiguration;

	[Header("Audio Clips")]
	[SerializeField] private AudioSO hover;
	[SerializeField] private AudioSO click;

	public void PlayHover() => PlayAudioClipRequest(hover, audioConfiguration, default);
	public void PlayClick() => PlayAudioClipRequest(click, audioConfiguration, default);
}
