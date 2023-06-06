using UnityEngine;
using UnityEngine.Audio;

/// <summary>
/// 
/// </summary>
[CreateAssetMenu(fileName = "NewAudioConfiguration", menuName = "Scriptable Objects/Config/Audio Configuration")]
public class AudioConfigurationSO : ScriptableObject
{
    [SerializeField] private AudioMixerGroup audioMixerGroup;

	[Header("Sound properties")]
	[SerializeField, Range(0f, 1f)] private float Volume = 1f;
	[SerializeField, Range(-3f, 3f)] private float Pitch = 1f;
	[SerializeField, Range(-1f, 1f)] private float PanStereo = 0f;
	[SerializeField, Range(0f, 1.1f)] private float ReverbZoneMix = 1f;

	[Header("Spatialisation")]
	[SerializeField, Range(0f, 1f)] private float SpatialBlend = 1f;
	[SerializeField] private AudioRolloffMode RolloffMode = AudioRolloffMode.Logarithmic;
	[SerializeField, Range(0.01f, 5f)] private float MinDistance = 0.1f;
	[SerializeField, Range(5f, 100f)] private float MaxDistance = 50f;
	[SerializeField, Range(0, 360)] private int Spread = 0;
	[SerializeField, Range(0f, 5f)] private float DopplerLevel = 1f;

	public void ApplyTo(AudioSource audioSource)
	{
		audioSource.outputAudioMixerGroup = audioMixerGroup;
		audioSource.volume = Volume;
		audioSource.pitch = Pitch;
		audioSource.panStereo = PanStereo;
		audioSource.reverbZoneMix = ReverbZoneMix;
		audioSource.spatialBlend = SpatialBlend;
		audioSource.rolloffMode = RolloffMode;
		audioSource.minDistance = MinDistance;
		audioSource.maxDistance = MaxDistance;
		audioSource.spread = Spread;
		audioSource.dopplerLevel = DopplerLevel;
	}
}
