using UnityEngine;
using UnityEngine.Events;
using ScriptableObjectArchitecture;

public class AudioSettingsGroupUI : MonoBehaviour
{
	[Header("Audio Components")]
	[SerializeField] private AudioSettingsUI masterSettingsUI;
	[SerializeField] private AudioSettingsUI musicSettingsUI;
	[SerializeField] private AudioSettingsUI sfxSettingsUI;

	[Header("Broadcasting on")]
	[SerializeField] private FloatGameEvent masterVolumeChangedEvent;
	[SerializeField] private FloatGameEvent musicVolumeChangedEvent;
	[SerializeField] private FloatGameEvent sfxVolumeChangedEvent;

    public event UnityAction<float, float, float> save = delegate { };

    private float masterVolume;
    private float musicVolume;
    private float sfxVolume;

    private float savedMasterVolume;
    private float savedMusicVolume;
    private float savedSfxVolume;

    private void OnEnable()
    {
        masterSettingsUI.volumeChange += ChangeMasterVolume;
        musicSettingsUI.volumeChange += ChangeMusicVolume;
        sfxSettingsUI.volumeChange += ChangeSFXVolume;
    }

    private void OnDisable()
    {
        masterSettingsUI.volumeChange -= ChangeMasterVolume;
        musicSettingsUI.volumeChange -= ChangeMusicVolume;
        sfxSettingsUI.volumeChange -= ChangeSFXVolume;
    }

    private void ChangeMasterVolume(float newVolume)
    {
        savedMasterVolume = masterVolume;
        masterVolume = newVolume;
    }
    
    private void ChangeMusicVolume(float newVolume)
    {
        savedMusicVolume = musicVolume;
        musicVolume = newVolume;
    }
    
    private void ChangeSFXVolume(float newVolume)
    {
        savedSfxVolume = sfxVolume;
        sfxVolume = newVolume;
    }

    public void SetUp(float newSavedMasterVolume, float newSavedMusicVolume, float newSavedSFXVolume)
    {
        masterVolume = newSavedMasterVolume;
        musicVolume = newSavedMusicVolume;
        sfxVolume = newSavedSFXVolume;

        masterSettingsUI.SetUpField(masterVolume);
        musicSettingsUI.SetUpField(musicVolume);
        sfxSettingsUI.SetUpField(sfxVolume);
    }

    public void SaveSettings()
    {
        save.Invoke(masterVolume, musicVolume, sfxVolume);

        SetMasterVolume();
        SetMusicVolume();
        SetSFXVolume();
    }

    private void SetMasterVolume()
    {
        masterVolumeChangedEvent?.Raise(masterVolume);
    }   
    
    private void SetMusicVolume()
    {
        musicVolumeChangedEvent?.Raise(musicVolume);
    }
    
    private void SetSFXVolume()
    {
        sfxVolumeChangedEvent?.Raise(sfxVolume);

    }
}
