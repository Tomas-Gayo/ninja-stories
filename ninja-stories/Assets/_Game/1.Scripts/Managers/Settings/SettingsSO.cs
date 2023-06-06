using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "SettingsSO", menuName = "Scriptable Objects/Settings")]
public class SettingsSO : ScriptableObject
{
	[Header("Audio Settings")]
	[SerializeField] private float masterVolume;
	[SerializeField] private float musicVolume;
	[SerializeField] private float sfxVolume;

	[Header("Language Settings")]
	[SerializeField] private Locale currentLocale = default;

	public float MasterVolume => masterVolume;
	public float MusicVolume => musicVolume;
	public float SfxVolume => sfxVolume;


    public void SaveAudioSettings(float newMasterVolume, float newMusicVolume, float newSfxVolume)
	{
		masterVolume = newMasterVolume;
		musicVolume = newMusicVolume;
		sfxVolume = newSfxVolume;
	}

	public void SaveLanguageSettings(Locale locale)
    {
		currentLocale = locale;
    }
}
