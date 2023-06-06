using UnityEngine;

	
/// <summary>
/// 
/// </summary>
public class SamuraiAudio : DefaultAudioChannel
{
	[SerializeField] private AudioConfigurationSO audioConfiguration;

	[Header("Audio Clips")]
	[SerializeField] private AudioSO footsteps;
	[SerializeField] private AudioSO lightAttack;
	[SerializeField] private AudioSO getHit;
	[SerializeField] private AudioSO sheathe;
	[SerializeField] private AudioSO unsheathe;

	public void PlayFootSteps() => PlayAudioClipRequest(footsteps, audioConfiguration, transform.position);
	public void PlayLightAttack() => PlayAudioClipRequest(lightAttack, audioConfiguration, transform.position);
	public void PlayGetHit() => PlayAudioClipRequest(getHit, audioConfiguration, transform.position);
	public void PlaySheathe() => PlayAudioClipRequest(sheathe, audioConfiguration, transform.position);
	public void PlayeUnsheathe() => PlayAudioClipRequest(unsheathe, audioConfiguration, transform.position);
}
