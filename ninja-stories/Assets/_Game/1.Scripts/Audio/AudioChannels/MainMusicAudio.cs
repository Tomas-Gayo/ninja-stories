using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class MainMusicAudio : DefaultAudioChannel
{
	[SerializeField] private AudioConfigurationSO audioConfiguration;

	[Header("Audio Clips")]
	[SerializeField] private AudioSO song;

	public void PlaySong() => PlayAudioClipRequest(song, audioConfiguration, transform.position);
}
