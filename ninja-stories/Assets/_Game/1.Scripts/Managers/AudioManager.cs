using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [Header("Pool Configuration")]
    [SerializeField] private ObjectPoolSO pool;
    [SerializeField] private PoolObject prefab;
    [SerializeField] private int numberOfEmitters;

    [Header("Audio control")]
    [SerializeField] private AudioMixer audioMixer = default;

    [SerializeField, Range(0f, 1f)] private float masterVolume = 1f;
    [SerializeField, Range(0f, 1f)] private float musicVolume = 1f;
    [SerializeField, Range(0f, 1f)] private float sfxVolume = 1f;

    private AudioEmitter musicAudioEmitter;

    private void Awake()
    {
        pool = ScriptableObject.CreateInstance<ObjectPoolSO>();
        pool.SetParent(transform);
        pool.Init(numberOfEmitters, prefab);
    }

    public void PlayAudioMusic(AudioRequest request)
    {
        if (musicAudioEmitter == null)
        {
            musicAudioEmitter = pool.Request<AudioEmitter>();
        }
        AudioClip clipToPlay = request.audioClips.GetClips()[0];
        musicAudioEmitter.PlayAudioClip(clipToPlay, request.audioConfig, request.audioClips.hasToLoop, default);
        musicAudioEmitter.OnSoundFinishedPlaying += StopAudioEmitter;
    }

    public void PlayAudioSFX(AudioRequest request)
    {
        AudioClip[] clipsToPlay = request.audioClips.GetClips();
        AudioEmitter[] SFXAudioEmitters = new AudioEmitter[clipsToPlay.Length];

        int numberOfClips = clipsToPlay.Length;
        for (int i = 0; i < numberOfClips; i++)
        {
            SFXAudioEmitters[i] = pool.Request<AudioEmitter>();
            if (SFXAudioEmitters[i] != null)
            {
                SFXAudioEmitters[i].PlayAudioClip(clipsToPlay[i], request.audioConfig, request.audioClips.hasToLoop, request.worldPosition);

                if (!request.audioClips.hasToLoop)
                {
                    SFXAudioEmitters[i].OnSoundFinishedPlaying += StopAudioEmitter;
                }
            }
        } 
    }

    private void StopAudioEmitter(AudioEmitter audioEmitter)
    {
        audioEmitter.OnSoundFinishedPlaying -= StopAudioEmitter;
        pool.Return(audioEmitter);
    }

    public void ChangeMasterVolume(float newVolume)
    {
        masterVolume = newVolume;
        SetGroupVolume("MasterVolume", masterVolume);
    }
    public void ChangeMusicVolume(float newVolume)
    {
        musicVolume = newVolume;
        SetGroupVolume("MusicVolume", musicVolume);
    }
    public void ChangeSFXVolume(float newVolume)
    {
        sfxVolume = newVolume;
        SetGroupVolume("SFXVolume", sfxVolume);
    }

    private void SetGroupVolume(string parameterName, float normalizedVolume)
    {
        bool volumeSet = audioMixer.SetFloat(parameterName, Mathf.Log10(normalizedVolume) * 20f);
        if (!volumeSet)
            Debug.LogError("The AudioMixer parameter was not found");
    }
}
