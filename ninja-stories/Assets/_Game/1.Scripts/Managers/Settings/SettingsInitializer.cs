using UnityEngine;
using ScriptableObjectArchitecture;

public class SettingsInitializer : MonoBehaviour
{
	[Header("Settings")]
	[SerializeField] private SettingsSO currentSettings;

	[Header("Broadcasting on")]
	[SerializeField] private FloatGameEvent masterVolumeChangedEvent;
	[SerializeField] private FloatGameEvent musicVolumeChangedEvent;
	[SerializeField] private FloatGameEvent sfxVolumeChangedEvent;

    private void Awake()
    {
		SetSettings();
    }

    public void SetSettings()
    {
        masterVolumeChangedEvent?.Raise(currentSettings.MasterVolume);
        musicVolumeChangedEvent?.Raise(currentSettings.MusicVolume);
        sfxVolumeChangedEvent?.Raise(currentSettings.SfxVolume);

    }
}
