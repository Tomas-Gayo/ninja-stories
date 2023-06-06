using UnityEngine;
using UnityEngine.Localization;

public class UISettings : MonoBehaviour
{
	[SerializeField] private SettingsSO currentSettings;

	[SerializeField] private AudioSettingsGroupUI audioSettings;
    [SerializeField] private LanguageSettingsUI languageSettings;

    private void OnEnable()
    {
        audioSettings.save += SaveAudioSettings;
        languageSettings.save += SaveLanguageSettings;
    }

    private void OnDisable()
    {
        audioSettings.save -= SaveAudioSettings;
    }

    private void Start()
    {
        audioSettings.SetUp(currentSettings.MasterVolume, currentSettings.MusicVolume, currentSettings.SfxVolume);
    }

    private void SaveAudioSettings(float masterVolume, float musicVolume, float sfxVolume)
    {
        currentSettings.SaveAudioSettings(masterVolume, musicVolume, sfxVolume);
    }

    private void SaveLanguageSettings(Locale locale)
    {
        currentSettings.SaveLanguageSettings(locale);
    }
}
