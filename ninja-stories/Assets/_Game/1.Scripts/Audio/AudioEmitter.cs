using System.Collections;
using UnityEngine;
using UnityEngine.Events;
	
/// <summary>
/// Controller of the audio source. Provide an audio request an it
/// it will play whatever you want
/// </summary>
[RequireComponent(typeof(AudioSource))]
public class AudioEmitter : PoolObject
{
    private AudioSource audioSource;

    public event UnityAction<AudioEmitter> OnSoundFinishedPlaying;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudioClip(AudioClip clip, AudioConfigurationSO audioConfig, bool isLooping, Vector3 position)
    {
        audioConfig.ApplyTo(audioSource);
        audioSource.clip = clip;
        audioSource.loop = isLooping;
        audioSource.transform.position = position;
        audioSource.time = 0;
        Init();

        if (!isLooping)
            StartCoroutine(FinishedPlaying(clip.length));
    }

    IEnumerator FinishedPlaying(float clipLength)
    {
        yield return new WaitForSeconds(clipLength);

        Release();
    }


    public override void Init()
    {
        audioSource.Play();
    }

    public override void Release()
    {
        audioSource.Stop();
        OnSoundFinishedPlaying.Invoke(this);
    }
}
